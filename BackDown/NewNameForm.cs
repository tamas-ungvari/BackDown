using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackDown
{
    public partial class NewNameForm : Form
    {
        public NewNameForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(nameTextBox.Text);
            if (e.Cancel)
            {
                nameTextBox.Focus();
                nameLabel.ForeColor = Color.Red;
                MessageBox.Show("Az új név nem lehet üres.");
            }
            else
            {
                nameLabel.ForeColor = Color.Black;
            }
        }
    }
}
