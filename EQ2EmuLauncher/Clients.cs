using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace EQ2EmuLauncher
{
    public partial class Clients : UserControl
    {
        private List<Client> m_clients;
        private Client m_editClient;
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            m_clients = EQ2EmuLauncher.GetClients();
            PopulateClientCombo();
            m_editClient = null;
        }

        #region Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Enable the controls
            lblName.Visible = true;
            txtName.Visible = true;
            lblLoc.Visible = true;
            txtLoc.Visible = true;
            btnBrowse.Visible = true;
            cbLive.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = true;
            btnEditSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // No client selected, return out as nothing to edit
            if (cmbClients.SelectedIndex < 0)
                return;

            // Enable the controls
            lblName.Visible = true;
            txtName.Visible = true;
            lblLoc.Visible = true;
            txtLoc.Visible = true;
            btnBrowse.Visible = true;
            cbLive.Visible = true;
            btnCancel.Visible = true;
            btnEditSave.Visible = true; 
            btnAddSave.Visible = false;
            
            // Fill in the controls
            txtName.Text = m_clients[cmbClients.SelectedIndex].Name;
            txtLoc.Text = m_clients[cmbClients.SelectedIndex].Path;
            cbLive.Checked = m_clients[cmbClients.SelectedIndex].IsLiveClient;

            // Store the client we are editing
            m_editClient = m_clients[cmbClients.SelectedIndex];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure we have a client selected before we try to delete
            if (cmbClients.SelectedIndex < 0)
                return;

            // Remove the client
            m_clients.RemoveAt(cmbClients.SelectedIndex);
            // Refresh the combo box
            PopulateClientCombo();
            HideControls();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "Select your EverQuest 2 folder";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fd.SelectedPath + "\\Everquest2.exe"))
                    txtLoc.Text = fd.SelectedPath;
                else
                    MessageBox.Show("Not a valid Everquest 2 Folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideControls();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Add Save");
            if (txtName.Text == string.Empty || txtLoc.Text == string.Empty)
            {
                MessageBox.Show("You must specify a name and a path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client();
            client.Name = txtName.Text;
            client.Path = txtLoc.Text;
            client.IsLiveClient = cbLive.Checked;
            // New client being added so default to last set = live
            client.LastSetting = client.GetLastSet();
            m_clients.Add(client);

            PopulateClientCombo();
            HideControls();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Edit Save");
            if (m_editClient == null)
                return;

            m_editClient.Name = txtName.Text;
            m_editClient.Path = txtLoc.Text;
            m_editClient.IsLiveClient = cbLive.Checked;

            PopulateClientCombo();
            HideControls();
        }
        #endregion

        #region Helper Functions
        private void PopulateClientCombo()
        {
            int index = cmbClients.SelectedIndex;
            cmbClients.BeginUpdate();
            cmbClients.Items.Clear();
            cmbClients.Text = string.Empty;

            foreach (Client client in m_clients)
                cmbClients.Items.Add(client.Name);

            if (cmbClients.Items.Count > 0 && index < cmbClients.Items.Count)
                cmbClients.SelectedIndex = Math.Max(0, index);
            else
                cmbClients.SelectedIndex = -1;

            cmbClients.SelectionLength = 0;
            cmbClients.EndUpdate();
        }

        private void HideControls()
        {
            lblName.Visible = false;
            txtName.Visible = false;
            txtName.Text = string.Empty;
            lblLoc.Visible = false;
            txtLoc.Visible = false;
            txtLoc.Text = string.Empty;
            btnBrowse.Visible = false;
            cbLive.Visible = false;
            btnCancel.Visible = false;
            btnEditSave.Visible = false;
            btnAddSave.Visible = false;
            m_editClient = null;
        }
        #endregion
    }
}
