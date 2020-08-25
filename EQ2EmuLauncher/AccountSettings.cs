using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQ2EmuLauncher
{
    public partial class AccountSettings : UserControl
    {
        private List<Account> m_accounts;
        private Account m_editAccount;

        public AccountSettings()
        {
            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            m_accounts = EQ2EmuLauncher.GetAccounts();
            PopulateAccountCombo();
            m_editAccount = null;
        }

        #region Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = true;
            btnEditSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbAccounts.SelectedIndex < 0)
                return;

            lblName.Visible = true;
            txtName.Visible = true;
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = true;

            m_editAccount = m_accounts[cmbAccounts.SelectedIndex];
            txtName.Text = m_editAccount.Name;
            txtUsername.Text = m_editAccount.Username;
            txtPassword.Text = m_editAccount.Password;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbAccounts.SelectedIndex < 0)
                return;

            // Remove all characters related to this account
            List<Character> characters = EQ2EmuLauncher.GetCharacters();
            characters.RemoveAll(c => c.Account == m_accounts[cmbAccounts.SelectedIndex].Name);

            // Remove the account
            m_accounts.RemoveAt(cmbAccounts.SelectedIndex);            

            PopulateAccountCombo();
            HideControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideControls();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("You must specify a name and a username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account act = new Account();
            act.Name = txtName.Text;
            act.Username = txtUsername.Text;
            act.Password = txtPassword.Text;
            m_accounts.Add(act);

            PopulateAccountCombo();
            HideControls();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (m_editAccount == null)
                return;

            m_editAccount.Name = txtName.Text;
            m_editAccount.Username = txtUsername.Text;
            m_editAccount.Password = txtPassword.Text;

            PopulateAccountCombo();
            HideControls();
        }
        #endregion

        #region Helper Functions
        public void PopulateAccountCombo()
        {
            int index = cmbAccounts.SelectedIndex;
            cmbAccounts.BeginUpdate();
            cmbAccounts.Items.Clear();
            cmbAccounts.Text = string.Empty;

            foreach (Account act in m_accounts)
                cmbAccounts.Items.Add(act.Name);

            if (cmbAccounts.Items.Count > 0 && index < cmbAccounts.Items.Count)
                cmbAccounts.SelectedIndex = Math.Max(0, index);
            else
                cmbAccounts.SelectedIndex = -1;

            cmbAccounts.SelectionLength = 0;
            cmbAccounts.EndUpdate();
        }

        private void HideControls()
        {
            lblName.Visible = false;
            txtName.Visible = false;
            txtName.Text = string.Empty;
            lblUsername.Visible = false;
            txtUsername.Visible = false;
            txtUsername.Text = string.Empty;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            txtPassword.Text = string.Empty;
            btnCancel.Visible = false;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;
            m_editAccount = null;
        }
        #endregion
    }
}
