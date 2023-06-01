using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;                 // hem instal·lat els paquets (Nuget) Aforge, Aforge.Video i Aforge.Video.DirectShow
using AForge.Video.DirectShow;

using QRCoder;          // hem instal·lat el paquet (NuGet) QR Coder de Raffael Herrmann
using ZXing;

namespace ExerciciQRSysTray
{
    public partial class fmMainQRSys : Form
    {
        public fmMainQRSys()
        {
            InitializeComponent();
        }

        //Declareacio de les variables globals
        FilterInfoCollection filtreCameres;
        VideoCaptureDevice kam = null; //Aqui declarem la camara i la posem en null per no ocupar res
        Bitmap bmp = null; //Aqui declarem el bitmap de la imatge que farem serbir en null per no ocupar res


        //Declarem un lector de codiqr i posem la autorotacio del codi qr a true
        BarcodeReader lector = new BarcodeReader { AutoRotate = true };

        //Declarem la string de textcodiqr
        string textcodiqr = null;
        string textcodiqranterior = null; //Declarem aquesta variable per que aixi farem un control per evitar que s'obrin 30 mil pestanyes amb la mateixa informacio

        
        //Iniciem el nom de la camara a null
        string nomcamara = null;

        //Cada cop que apretem al boto de tancar el systray es tancara el programa
        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Com que no volem que hi hagi cap error, tancarem la camara abans de tancar el programa
            aturarcam(); 

            //Aqui tanquem el programa amb normalitat
            this.Close();
        }

        private void activarCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Aquesta sera la funcio de obrir la camara
            obrirCamara();
        }

        private void nouFotograma(object sender, NewFrameEventArgs eventArgs)
        {
            //Per cada fotograma que capti la camara cridara aquesta funcio

            //Aqui guardem la imatge que ens arriba de la camara en el bitmap
            bmp = (Bitmap)(Image)eventArgs.Frame.Clone();
            //Declarem el texte del textbox a null
            //Aquesta funcio no fa falta ja que no farem res amb el text que estigui adalt, ni el llegim ni tenim temps a mostrarlo per la velocitat dels frames
            tbQR.Text = "";

            var l = lector.Decode(bmp); //Aqui fa el decode de la imatge de la camara i busca un codi qr a la imatge
            //IMPORTANT!: Si no hem detectat cap codi qr, el valor de "l" sera null, en cas contrari, si ha pogut llegir un qr retorna el seu valor corresponent i no null
            if (l != null) 
            {
                //Aqui asignem el text del codiqr a la variable textcodiqr
                textcodiqr = l.Text.ToString();

                //Si la variable textcodiqr es diferent de la variable textcodiqranterior, vol dir que hem llegit un codiqr diferent, entrara a dins del if
                if (textcodiqr != textcodiqranterior)
                {
                    //Arranquem un proces amb el text codi qr que ha trobat, com que sera sempre un link, al arrancar un proces i passarli un link automaticament t'obre el navegador web
                    Process.Start(textcodiqr);

                    //I assignem el valor de textcodi qr ACTUAL a text codi qr anterior perque no torni a entrar a dins del bucle
                    textcodiqranterior = textcodiqr;
                }
                

                
            }
            
        }

        private void obrirCamara()
        {
            //Aquesta es la funcio que farem servir per obrir les camares
            kam = new VideoCaptureDevice(filtreCameres[0].MonikerString);
            kam.NewFrame += nouFotograma;
            kam.Start(); //Com que encara no tenim el programa acabat no executarem la camara fins que no vagi tot be
        }

        

        private void fmMainQRSys_Load(object sender, EventArgs e)
        {
            //Cada cop que executem el programa, executarem la funcio de veure quines camares tenim disponibles
            getCameres();
        }

        private void getCameres()
        {
            //Fem una array que ens mostrara totes les camares del ordinador
            filtreCameres = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Per cada camara que trobi, farem una volta al bucle
            foreach (FilterInfo p in filtreCameres)
            {
                //Si el nom de la camara ES DIFERENT a OBS Virtual Cam, entrara a dins del if
                if (p.Name != "OBS Virtual Camera")
                {
                    //Aqui el valor de nomcamara ha de ser una merda generica com "HD Webcam" o alguna merda aixi
                    nomcamara = (p.Name);
                }
                
            }
        }

        private void desactivarCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aquesta es la funcio que tancarem la camara
            aturarcam();
        }

        private void aturarcam()
        {
            //Com que no sabem si la camara esta oberta o no, farem un if per comprovar-ho
            if ((kam != null) && (kam.IsRunning))
            {
                //Si la camara esta encesa, la tancarem
                kam.Stop();
                //I declararem la KAM a null per no ocupar espai en ram
                kam = null;
            }
        }

        private void fmMainQRSys_FormClosing(object sender, FormClosingEventArgs e)
        {
            aturarcam();
        }

        private void niIcona_MouseClick(object sender, MouseEventArgs e)
        {
            //Si la icona de angrybirds rep un click, entrara a dins d'aquesta funcio

            //Si el boto que s'ha apretat és el boto esquerra entrara a dins del if
            if (e.Button == MouseButtons.Left)
            {
                //Provant i fent varies coses he conseguit mostrar el menu de la app amb el boto esquerra
                cmMenuStripIcona.Show(Cursor.Position);
                //niIcona.ShowBalloonTip(3000);
            }
        }

        private void generarQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cada cop que apretem al boto de generar qr, obrira una nova finestra
            fmMainQRSys fmMain = new fmMainQRSys();
            fmMain.WindowState = FormWindowState.Normal;
            fmMain.Visible = true;
           
        }

        private void btCrearQR_Click(object sender, EventArgs e)
        {
            if (tbQR.Text.Trim() == "")
            {
                //Aqui entrara si no has posat cap text per convertir a qr
                MessageBox.Show("Has d'introduir un text per a generar el QR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Aqui fem la generacio del codi qr
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData qrData = qr.CreateQrCode(tbQR.Text.Trim(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);

                imgQR.Image = qrCodeImage;
                imgQR.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
