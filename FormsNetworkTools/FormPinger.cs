using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//****************************************************** OKNO PINGER
namespace FormsNetworkTools
{
    public partial class FormPinger : Form
    {
        static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer(); //Deklaracja timer1
        public FormPinger()
        {
            InitializeComponent();
            SetTimer();            //Uruchomienie timera
        }
        private void ButtonPing_Click(object sender, EventArgs e) //Button uruchamiający pingowanie
        {
            TimerStartStop();
        }
        private void ButtonClear_Click(object sender, EventArgs e) // Button uruchamiający czyszczenie textboksa z wynikami pingu
        {
            ClearTextBox2();
            ClearTextBox1();
        }
        private void buttonReturnToMain_Click(object sender, EventArgs e) // Button otwierający okno Główne
        {
            RunMainForm();
        }
        private void Timer1_Tick(Object sender, EventArgs e) // Definicja fazy timera1
        {
            string address = textBox1.Text.ToString();      //Przypisanie do zmiennej address wartosci z textBox1
            string pingAnswer = BasicNettworkTools.RunSynchPing(address);//Przypisanie do zmiennej pingAnswer wyniku z funkcji pingującej
            if (pingAnswer != "wrong")
            {   
                textBox2.Text += pingAnswer;                    //Dodawanie linijki pingu
                textBox2.SelectionStart = textBox2.Text.Length; //Przewijanie tekstu do ostatniej linijki
                textBox2.ScrollToCaret();                       //Przewijanie tekstu do ostatniej linijki
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                buttonPing.Text = "Ping";
                textBox2.Text = "Wrong Ip address format";
            }
            
        }
        private void RunMainForm() // Metoda otwierająca okno Główne
        {
            this.Hide();
            FormMain fMain = new FormMain();
            fMain.ShowDialog();
            this.Close();
        }
        private void TimerStartStop()           //Metoda włączająca i wyłączająca timer1
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                buttonPing.Text = "Ping";
                timer1.Stop();
            }
            else if (timer1.Enabled == false)
            {
                ClearTextBox2();
                timer1.Enabled = true;
                buttonPing.Text = "Stop";
                timer1.Start();
            }
        }
        private void SetTimer()                 //Metoda ustawiająca timer1
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);
        }
        private void ClearTextBox2()             //Metoda usuwająca zawartość TextBox2
        {
            textBox2.Text = "";
        }
        private void ClearTextBox1()             //Metoda usuwająca zawartość TextBox1
        {
            textBox1.Text = "";
        }

        
    }  
}
