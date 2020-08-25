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
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (EQ2EmuLauncher.Options is Clients)
                return;

            EQ2EmuLauncher.Options.Dispose();
            EQ2EmuLauncher.Options = new Clients();
            EQ2EmuLauncher.Options.Left = EQ2EmuLauncher.OPTIONS_LOC_X;
            EQ2EmuLauncher.Options.Top = EQ2EmuLauncher.OPTIONS_LOC_Y;
            EQ2EmuLauncher.Options.Parent = Application.OpenForms[0];
            EQ2EmuLauncher.Options.Show();
            EQ2EmuLauncher.Options.BringToFront();
            EQ2EmuLauncher.OptionsMenu.BringToFront();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (EQ2EmuLauncher.Options is AccountSettings)
                return;

            EQ2EmuLauncher.Options.Dispose();
            EQ2EmuLauncher.Options = new AccountSettings();
            EQ2EmuLauncher.Options.Left = EQ2EmuLauncher.OPTIONS_LOC_X;
            EQ2EmuLauncher.Options.Top = EQ2EmuLauncher.OPTIONS_LOC_Y;
            EQ2EmuLauncher.Options.Parent = Application.OpenForms[0];
            EQ2EmuLauncher.Options.Show();
            EQ2EmuLauncher.Options.BringToFront();
            EQ2EmuLauncher.OptionsMenu.BringToFront();
        }

        private void btnCharacters_Click(object sender, EventArgs e)
        {
            if (EQ2EmuLauncher.Options is CharacterSettings)
                return;

            EQ2EmuLauncher.Options.Dispose();
            EQ2EmuLauncher.Options = new CharacterSettings();
            EQ2EmuLauncher.Options.Left = EQ2EmuLauncher.OPTIONS_LOC_X;
            EQ2EmuLauncher.Options.Top = EQ2EmuLauncher.OPTIONS_LOC_Y;
            EQ2EmuLauncher.Options.Parent = Application.OpenForms[0];
            EQ2EmuLauncher.Options.Show();
            EQ2EmuLauncher.Options.BringToFront();
            EQ2EmuLauncher.OptionsMenu.BringToFront();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            EQ2EmuLauncher.ResetCombos();
            EQ2EmuLauncher.Options.Dispose();
            EQ2EmuLauncher.OptionsMenu.Dispose();
            EQ2EmuLauncher.Options = null;
            EQ2EmuLauncher.OptionsMenu = null;
        }
    }
}
