using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wilkinson
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        //Cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Exit button
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        //ComboBoxSurfaceMaterial dropdown
        private void comboBoxSurfaceMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSurfaceMaterial == null)
            {
                comboBoxSurfaceMaterial.Text = String.Empty;
                comboBoxSurfaceMaterial.ForeColor = Color.Red;
                Console.WriteLine("Please select an option from the list.");
            }
        }

        //ComboBoxSurfaceMaterial dropdown test. May need to delete.
        private void comboBoxSurfaceMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
