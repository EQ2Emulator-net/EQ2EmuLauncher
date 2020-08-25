using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EQ2EmuLauncher
{
    public partial class EQ2EmuLauncher : Form
    {
        private static List<Client> m_clients = new List<Client>();
        private static List<Account> m_accounts = new List<Account>();
        private static List<Character> m_characters = new List<Character>();
        private static List<Character> m_currentCharacters = new List<Character>();
        public static bool UseLauncher = false;
        public static int LastClient = 0;
        public static int LastAccount = 0;
        public static UserControl OptionsMenu;
        public static UserControl Options;
        public const int OPTIONS_MENU_LOC_X = 310;
        public const int OPTIONS_MENU_LOC_Y = 162;
        public const int OPTIONS_LOC_X = 450;
        public const int OPTIONS_LOC_Y = 162;

        public static List<Client> GetClients()
        {
            return m_clients;
        }

        public static List<Account> GetAccounts()
        {
            return m_accounts;
        }

        public static List<Character> GetCharacters()
        {
            return m_characters;
        }

        public EQ2EmuLauncher()
        {
            InitializeComponent();
            
            // Pick a random back ground
            Random rand = new Random(System.DateTime.Now.Millisecond);
            switch (rand.Next(0, 4))
            {
                case 0:
                    BackgroundImage = Resources.Background;
                    break;
                case 1:
                    BackgroundImage = Resources.Background2;
                    break;
                case 2:
                    BackgroundImage = Resources.Background3;
                    break;
                case 3:
                    BackgroundImage = Resources.Background4;
                    break;
            }
            
            // Add the news window
            //310, 228
            NewsFeed news = new NewsFeed();
            news.Left = 310;
            news.Top = 228;
            news.Parent = this;
            news.Show();
            news.BringToFront();
        }

        private void EQ2EmuLauncher_Load(object sender, EventArgs e)
        {
            Settings.Load();
            cbUseLauncher.Checked = UseLauncher;
            PopulateClientCombo();
            PopulateAccountCombo();
            PopulateCharacterCombo();
            UpdateButtons();
            SetComboSelects();
        }

        #region Form Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EQ2EmuLauncher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Save(m_clients, m_accounts, m_characters, cmbClients.SelectedIndex, cmbAccounts.SelectedIndex);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // make the window moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void EQ2EmuLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Don't open the options if it is already open
            if (OptionsMenu != null)
                return;

            OptionsMenu = new Options();
            Options = new Clients();

            OptionsMenu.Left = OPTIONS_MENU_LOC_X;
            OptionsMenu.Top = OPTIONS_MENU_LOC_Y;

            Options.Left = OPTIONS_LOC_X;
            Options.Top = OPTIONS_LOC_Y;

            // Set parent after location to prevent a flicker on the screen
            OptionsMenu.Parent = this;
            Options.Parent = this;

            Options.Show();
            Options.BringToFront();

            OptionsMenu.Show();
            OptionsMenu.BringToFront();
        }

        public static void ResetCombos()
        {
            ((EQ2EmuLauncher)Application.OpenForms[0]).PopulateClientCombo();
            ((EQ2EmuLauncher)Application.OpenForms[0]).PopulateAccountCombo();
            ((EQ2EmuLauncher)Application.OpenForms[0]).PopulateCharacterCombo();
        }

        private void SetComboSelects()
        {
            if (cmbClients.Items.Count != 0) { cmbClients.SelectedIndex = LastClient; }
            if (cmbAccounts.Items.Count != 0) { cmbAccounts.SelectedIndex = LastAccount; }
        }

        private void UpdateLaunchButton(string txt)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { UpdateLaunchButton(txt); }));
                return;
            }

            btnLaunch.Text = txt;
        }
        #endregion

        #region clients
        public static void AddClient(Client client)
        {
            m_clients.Add(client);
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        public void PopulateClientCombo()
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

        private void btnEmu_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex < 0)
                return;

            string eq2_default = m_clients[cmbClients.SelectedIndex].Path + "\\eq2_default.ini";
            StreamReader sr = new StreamReader(eq2_default);
            List<string> strings = new List<string>();
            while (!sr.EndOfStream)
                strings.Add(sr.ReadLine());

            sr.Close();

            if (strings[0].StartsWith("cl_ls_address"))
                strings[0] = "cl_ls_address www.eq2emulator.net";

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].StartsWith("cl_resource_address"))
                    strings[i] = "// " + strings[i];
            }

            StreamWriter sw = new StreamWriter(eq2_default);
            for (int i = 0; i < strings.Count; i++)
                sw.WriteLine(strings[i]);

            sw.Close();

            m_clients[cmbClients.SelectedIndex].LastSetting = LastSet.EQ2Emulator;
            UpdateButtons();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex < 0)
                return;

            string eq2_default = m_clients[cmbClients.SelectedIndex].Path + "\\eq2_default.ini";
            StreamReader sr = new StreamReader(eq2_default);
            List<string> strings = new List<string>();
            while (!sr.EndOfStream)
                strings.Add(sr.ReadLine());

            sr.Close();

            if (strings[0].StartsWith("cl_ls_address"))
                strings[0] = "cl_ls_address 127.0.0.1";

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].StartsWith("cl_resource_address"))
                    strings[i] = "// " + strings[i];
            }

            StreamWriter sw = new StreamWriter(eq2_default);
            for (int i = 0; i < strings.Count; i++)
                sw.WriteLine(strings[i]);

            sw.Close();

            m_clients[cmbClients.SelectedIndex].LastSetting = LastSet.Localhost;
            UpdateButtons();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            CustomServer cs = new CustomServer();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                if (cmbClients.SelectedIndex < 0)
                    return;

                string eq2_default = m_clients[cmbClients.SelectedIndex].Path + "\\eq2_default.ini";
                StreamReader sr = new StreamReader(eq2_default);
                List<string> strings = new List<string>();
                while (!sr.EndOfStream)
                    strings.Add(sr.ReadLine());

                sr.Close();

                if (strings[0].StartsWith("cl_ls_address"))
                    strings[0] = "cl_ls_address " + CustomServer.Address;

                for (int i = 0; i < strings.Count; i++)
                {
                    if (strings[i].StartsWith("cl_resource_address"))
                        strings[i] = "// " + strings[i];
                }

                StreamWriter sw = new StreamWriter(eq2_default);
                for (int i = 0; i < strings.Count; i++)
                    sw.WriteLine(strings[i]);

                sw.Close();

                m_clients[cmbClients.SelectedIndex].LastSetting = LastSet.Custom;
                UpdateButtons();
            }
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex < 0)
                return;

            string eq2_default = m_clients[cmbClients.SelectedIndex].Path + "\\eq2_default.ini";
            StreamReader sr = new StreamReader(eq2_default);
            List<string> strings = new List<string>();
            while (!sr.EndOfStream)
                strings.Add(sr.ReadLine());

            sr.Close();

            if (strings[0].StartsWith("cl_ls_address"))
                strings[0] = "cl_ls_address 69.174.200.10 69.174.200.20 69.174.200.30 69.174.200.60 69.174.200.70 69.174.200.90 69.174.200.100";

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].StartsWith("cl_resource_address"))
                    strings[i] = "// " + strings[i];
            }

            StreamWriter sw = new StreamWriter(eq2_default);
            for (int i = 0; i < strings.Count; i++)
                sw.WriteLine(strings[i]);

            sw.Close();

            m_clients[cmbClients.SelectedIndex].LastSetting = LastSet.Live;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (cmbClients.SelectedIndex < 0 || cmbClients.SelectedIndex >= m_clients.Count)
                return;

            switch (m_clients[cmbClients.SelectedIndex].LastSetting)
            {
                case LastSet.Localhost:
                    btnLocal.Enabled = false;
                    btnLive.Enabled = true;
                    btnEmu.Enabled = true;
                    break;
                case LastSet.Live:
                    btnLocal.Enabled = true;
                    btnLive.Enabled = false;
                    btnEmu.Enabled = true;
                    break;
                case LastSet.EQ2Emulator:
                    btnLocal.Enabled = true;
                    btnLive.Enabled = true;
                    btnEmu.Enabled = false;
                    break;
                default:
                    btnLocal.Enabled = true;
                    btnLive.Enabled = true;
                    btnEmu.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Accounts
        public static void AddAccount(Account account)
        {
            m_accounts.Add(account);
        }

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
        #endregion

        #region Launch Client
        private void cbUseLauncher_CheckedChanged(object sender, EventArgs e)
        {
            UseLauncher = cbUseLauncher.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex < 0 || btnLaunch.Text == "Launching...")
                return;

            // Flag to watch the clients memory
            bool watch_proc = false;
            string everquest2 = m_clients[cmbClients.SelectedIndex].Path + "\\";
            Process proc = new Process();

            // WorkingDirectory needs to be set as EverQuest2.exe will look for its assets in this folder
            proc.StartInfo.WorkingDirectory = everquest2;

            // Use EQ2.exe if the client is set to live, marked as a live client, and option to use launcher is selected
            if (m_clients[cmbClients.SelectedIndex].IsLiveClient && m_clients[cmbClients.SelectedIndex].LastSetting == LastSet.Live && UseLauncher)
                proc.StartInfo.FileName = everquest2 + "EQ2.exe";
            else
            {
                // Change the launch button to launching, this will also disable it
                // also set the flag to watch the clients memory
                UpdateLaunchButton("Launching...");
                watch_proc = true;

                proc.StartInfo.FileName = everquest2 + "EverQuest2.exe";

                //FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(proc.StartInfo.FileName);
                //MessageBox.Show(myFileVersionInfo.ProductVersion);
                /* CL[ 610541 ] Build[ 11758L ] */
                //return;

                // Do not set command line if the client is set to live
                if (m_clients[cmbClients.SelectedIndex].LastSetting != LastSet.Live)
                {
                    // Command line parameters are only for account and password and only set them when using EverQuest2.exe
                    if (cmbAccounts.Items.Count > 0 && cmbAccounts.SelectedIndex >= 0)
                    {
                        Account account = m_accounts[cmbAccounts.SelectedIndex];
                        if (account.Username != string.Empty)
                        {
                            proc.StartInfo.Arguments = "cl_username " + account.Username;
                            // Only set the password if a username is set
                            if (account.Password != string.Empty)
                                proc.StartInfo.Arguments += "; cl_sessionid " + account.Password;

                            if (cmbCharacters.SelectedIndex > 0)
                            {
                                // Subtract one from selected index because we add a blank spot
                                Character c = m_currentCharacters[cmbCharacters.SelectedIndex - 1];
                                proc.StartInfo.Arguments += "; cl_autoplay_char " + c.CharacterName + "; cl_autoplay_world " + c.World;
                            }
                        }
                    }
                }
            }
            proc.Start();

            if (watch_proc)
            {
                // Watch the clients memory so we know when to re-enable the launch button
                Thread thread = new Thread(new ParameterizedThreadStart(WatchClient));
                thread.Start(proc);
            }


            // Sample of how SOE launchpad starts up EverQuest2.exe
            // "D:\EverQuest 2\EverQuest2.exe" cl_sessionid AKFHVwdfXWI5oRsQ; cl_username betacollector2; LaunchPadSessionId 1389294169; LaunchPadUfp 1d196a43-00005835-00004116-a858d5b9-31f40319;

            // Sample of SOE launchpad starting EverQuest2.exe with an auto login character
            // "D:\EverQuest 2\EverQuest2.exe" cl_sessionid AjUmiY48ItJaPFBJ; cl_username betacollector2; LaunchPadSessionId 1390163303; LaunchPadUfp 1d196a43-00005835-00004116-a858d5b9-31f40319; cl_autoplay_char XXXXX; cl_autoplay_world Guk;
        }

        private void WatchClient(Object obj)
        {
            if (!(obj is Process))
                return;

            Process proc = obj as Process;

            bool wait = true;

            while (wait)
            {
                try
                {
                    proc.Refresh();
                    Thread.Sleep(100);

                    double memUseage = proc.WorkingSet64 / 1024; // 1024 for KB 1048576 for MB
                    
                    // If the clients memory is over 60mb it is more then likely open so we can re-enable the launch button
                    if (memUseage >= 60000)
                    {
                        wait = false;
                        UpdateLaunchButton("Launch");
                    }
                    else
                        Thread.Sleep(400); // total of 500 delay, 0.5 sec

                }
                catch (Exception e)
                {
                    // Added this try catch as it was possible for the world server to close while in the while loop causing a crash, this prevents it
                }
            }
        }
        #endregion

        #region Characters
        // In the characters region as it is responsible for the character combo box
        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCharacterCombo();
        }

        private void PopulateCharacterCombo()
        {
            cmbCharacters.BeginUpdate();
            cmbCharacters.Items.Clear();
            m_currentCharacters.Clear();

            // Add a blank space so you can clear character selection if you want to
            cmbCharacters.Items.Add("");
            if (cmbAccounts.SelectedIndex >= 0)
            {
                foreach (Character c in m_characters)
                {
                    if (cmbAccounts.Items[cmbAccounts.SelectedIndex].ToString() == c.Account)
                    {
                        cmbCharacters.Items.Add(c.Name);
                        m_currentCharacters.Add(c);
                    }
                }
            }
            cmbCharacters.SelectedIndex = 0;
            cmbCharacters.EndUpdate();
        }

        public static void AddCharacter(Character c)
        {
            m_characters.Add(c);
        }
        #endregion
    }
}
