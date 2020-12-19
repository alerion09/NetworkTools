using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
//*******************************OKNO GŁÓWNE
namespace FormsNetworkTools
{
    public partial class FormMain : Form
    {
        static System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer(); // Deklaracja timer2
        public FormMain()
        {
            InitializeComponent();
            labelNetworkInformationsOutput.Text = "Host name: " +  BasicNettworkTools.GetHostName(); // Podmiana labelu na nazwę hosta
            SetTimer2();                //Uruchomienie Timera z metodą odpowiedzialną za puszczanie pingu
        }

        private void buttonRunPinger_Click(object sender, EventArgs e) // Button otwierający okno Pinger
        {
            this.Hide();
            FormPinger fPinger = new FormPinger();
            fPinger.ShowDialog();
            this.Close();
        }

        private void buttonRunInterfacesInfo_Click(object sender, EventArgs e)      // Button otwierający okno Informacje o Interfejsach
        {
            this.Hide();
            FormInterfacesInfo fInterfaces = new FormInterfacesInfo();
            fInterfaces.ShowDialog();
            this.Close();
        }
        private bool IsInternet ()                  //Metoda sprawdzająca czy dociera Ping do Dns i strony Bing
        {
            string answer = BasicNettworkTools.RunSynchPing("8.8.8.8");
            string answer2 = BasicNettworkTools.RunSynchPing("www.bing.com");
            string replyContent = "Reply";
            if (answer.Contains(replyContent))
            {
                return true;
            }
            else if (answer2.Contains(replyContent))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SetTimer2()                 //Metoda ustawiająca timer2
        {
            ChangelabelInternetStatusText();    //Pierwsze uruchomienie metody powodującej zmianę tekstu, przed minięciem czasu interwału
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(Timer2_Tick);
        }
        private void Timer2_Tick(Object sender, EventArgs e)        //Metoda wykonująca się po uruchomieniu timer2
        {
            ChangelabelInternetStatusText();
        }
        private void ChangelabelInternetStatusText()    //Zmiana textu labelInternetStatus na informację o statusie połączenia z internetem
        {
            if (IsInternet()) 
            {
                labelInternetStatus.Text = "Internet status: Active.";
            }
            else
            {
                labelInternetStatus.Text = "Internet status: Inactive.";
            }
        }
    }
}
