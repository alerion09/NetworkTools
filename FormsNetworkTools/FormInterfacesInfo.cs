using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// **************************************OKNO INFORMACJE O INTERFEJSACH
namespace FormsNetworkTools
{
    public partial class FormInterfacesInfo : Form
    {
        public FormInterfacesInfo()
        {
            InitializeComponent();
            textBoxFullInterfacesInformationsOutput.Text = BasicNettworkTools.GetInterfacesInfo(); // Zamiana textu labelu na informacje o interfejsach
                                                                                                   //z wykorzystaniem klasy abstrakcyjnej
        }

        private void buttonReturnToMain_Click(object sender, EventArgs e) // Button uruchamiający okno Główne
        {
            RunMainForm();
        }
        private void RunMainForm() // Metoda otwierająca okno Główne
        {
            this.Hide();
            FormMain fMain = new FormMain();
            fMain.ShowDialog();
            this.Close();
        }
    }
   
}
