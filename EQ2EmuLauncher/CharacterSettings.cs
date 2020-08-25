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
    public partial class CharacterSettings : UserControl
    {
        private List<Character> m_characters;
        private Character m_editCharacter;

        public CharacterSettings()
        {
            InitializeComponent();
        }

        private void CharacterSettings_Load(object sender, EventArgs e)
        {
            m_characters = EQ2EmuLauncher.GetCharacters();
            PopulateCharacterCombo();

            List<Account> accounts = EQ2EmuLauncher.GetAccounts();
            foreach (Account act in accounts)
                cmbAccounts.Items.Add(act.Name);
        }

        #region Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblAccount.Visible = true;
            cmbAccounts.Visible = true;
            lblCharacterName.Visible = true;
            txtCharacterName.Visible = true;
            lblServer.Visible = true;
            txtServer.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = true;
            btnEditSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbCharacter.SelectedIndex < 0)
                return;

            lblName.Visible = true;
            txtName.Visible = true;
            lblAccount.Visible = true;
            cmbAccounts.Visible = true;
            lblCharacterName.Visible = true;
            txtCharacterName.Visible = true;
            lblServer.Visible = true;
            txtServer.Visible = true;
            btnCancel.Visible = true;
            btnAddSave.Visible = false;
            btnEditSave.Visible = true;

            m_editCharacter = m_characters[cmbCharacter.SelectedIndex];
            txtName.Text = m_editCharacter.Name;
            txtCharacterName.Text = m_editCharacter.CharacterName;
            txtServer.Text = m_editCharacter.World;

            int index = cmbAccounts.FindString(m_editCharacter.Account);
            cmbAccounts.SelectedIndex = index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCharacter.SelectedIndex < 0)
                return;

            m_characters.RemoveAt(cmbCharacter.SelectedIndex);
            PopulateCharacterCombo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideControls();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCharacterName.Text == string.Empty || txtName.Text == string.Empty || txtServer.Text == string.Empty || cmbAccounts.SelectedIndex < 0)
            {
                MessageBox.Show("You must fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Character c = new Character();
            c.Name = txtName.Text;
            c.Account = cmbAccounts.Items[cmbAccounts.SelectedIndex].ToString();
            c.CharacterName = txtCharacterName.Text;
            c.World = txtServer.Text;

            m_characters.Add(c);
            PopulateCharacterCombo();
            HideControls();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (m_editCharacter == null)
                return;

            m_editCharacter.Name = txtName.Text;
            m_editCharacter.Account = cmbAccounts.SelectedText;
            m_editCharacter.CharacterName = txtCharacterName.Text;
            m_editCharacter.World = txtServer.Text;

            PopulateCharacterCombo();
            HideControls();
        }
        #endregion

        #region Helper Functions
        public void PopulateCharacterCombo()
        {
            int index = cmbCharacter.SelectedIndex;
            cmbCharacter.BeginUpdate();
            cmbCharacter.Items.Clear();
            cmbCharacter.Text = string.Empty;

            foreach (Character c in m_characters)
                cmbCharacter.Items.Add(c.Name);

            if (cmbCharacter.Items.Count > 0 && index < cmbCharacter.Items.Count)
                cmbCharacter.SelectedIndex = Math.Max(0, index);
            else
                cmbCharacter.SelectedIndex = -1;

            cmbCharacter.SelectionLength = 0;
            cmbCharacter.EndUpdate();
        }

        private void HideControls()
        {
            lblName.Visible = false;
            txtName.Visible = false;
            txtName.Text = string.Empty;
            lblAccount.Visible = false;
            cmbAccounts.Visible = false;
            lblCharacterName.Visible = false;
            txtCharacterName.Visible = false;
            txtCharacterName.Text = string.Empty;
            lblServer.Visible = false;
            txtServer.Visible = false;
            txtServer.Text = string.Empty;
            btnCancel.Visible = false;
            btnAddSave.Visible = false;
            btnEditSave.Visible = false;

            m_editCharacter = null;
        }
        #endregion
    }
}
