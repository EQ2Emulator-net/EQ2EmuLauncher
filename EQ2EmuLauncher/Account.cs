using System;

namespace EQ2EmuLauncher
{
    public class Account
    {
        private string m_name;
        private string m_username;
        private string m_password;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public string Username
        {

            get { return m_username; }
            set { m_username = value; }
        }

        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
    }
}
