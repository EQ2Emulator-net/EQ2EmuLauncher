using System;
using System.Collections.Generic;
using System.IO;

namespace EQ2EmuLauncher
{
    public enum LastSet {
        Localhost,
        EQ2Emulator,
        Live,
        Custom
    }

    public class Client
    {
        private string m_name;
        private string m_path;
        private bool m_liveClient;
        private LastSet m_lastSet;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public string Path
        {
            get { return m_path; }
            set { m_path = value; }
        }

        public bool IsLiveClient
        {
            get { return m_liveClient; }
            set { m_liveClient = value; }
        }

        public LastSet LastSetting
        {
            get { return m_lastSet; }
            set { m_lastSet = value; }
        }

        public LastSet GetLastSet()
        {
            string eq2_default = m_path + "\\eq2_default.ini";
            if (!File.Exists(eq2_default))
            {
                return LastSet.Custom;
            }

            StreamReader sr = new StreamReader(eq2_default);
            List<string> strings = new List<string>();
            while (!sr.EndOfStream)
                strings.Add(sr.ReadLine());

            sr.Close();

            for (int i = 0; i < strings.Count; i++)
            {
                // this will probably always be on the first line, but put it in the loop in the very rare occasion that it is not
                if (strings[i].StartsWith("cl_ls_address"))
                {
                    if (strings[i] == "cl_ls_address clientls.eq2emulator.net")
                        return LastSet.EQ2Emulator;
                    if (strings[i] == "cl_ls_address localhost" || strings[i] == "cl_ls_address 127.0.0.1")
                        return LastSet.Localhost;
                    if (strings[i] == "cl_ls_address 69.174.200.10 69.174.200.20 69.174.200.30 69.174.200.60 69.174.200.70 69.174.200.90 69.174.200.100")
                        return LastSet.Live;
                }
            }

            return LastSet.Custom;
        }
    }
}
