using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ2EmuLauncher
{
    public class Character
    {
        private string m_name;
        private string m_account;
        private string m_characterName;
        private string m_world;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public string Account
        {
            get { return m_account; }
            set { m_account = value; }
        }

        public string CharacterName
        {
            get { return m_characterName; }
            set { m_characterName = value; }
        }

        public string World
        {
            get { return m_world; }
            set { m_world = value; }
        }
    }
}
