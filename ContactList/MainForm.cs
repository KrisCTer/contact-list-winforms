using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            // Create an instance of the AddContactForm
            AddContactForm addContactForm = new AddContactForm();

            // Show the AddContactForm
            // Use ShowDialog() for a modal form (blocks interaction with MainForm until closed)
            // Use Show() for a non-modal form (allows interaction with MainForm while AddContactForm is open)
            addContactForm.ShowDialog();
            // Or: addContactForm.Show();
        }
    }
}
