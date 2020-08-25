using System;
using System.Windows.Forms;

namespace EQ2EmuLauncher
{
    public partial class CustomServer : Form
    {
        public static string Address;
        public CustomServer()
        {
            InitializeComponent();
        }

        private void txtIP_Enter(object sender, EventArgs e)
        {
            if (txtIP.Text == "IP Address")
                txtIP.Text = string.Empty;
        }

        private void txtPort_Enter(object sender, EventArgs e)
        {
            if (txtPort.Text == "Port")
                txtPort.Text = string.Empty;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "IP Address" || txtIP.Text == string.Empty)
            {
                MessageBox.Show("You need to enter an ip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address = txtIP.Text;
            if (txtPort.Text != string.Empty && txtPort.Text != "Port")
                Address += ":" + txtPort.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
