using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Net;
using System.Windows.Forms;


namespace EQ2EmuLauncher
{
    public class Settings
    {
        public static void Load()
        {
            if (!File.Exists("settings.xml"))
                return;

            XmlReader reader = XmlReader.Create("settings.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Client")
                {
                    Client client = new Client();
                    client.Name = reader.GetAttribute(0);
                    client.IsLiveClient = reader.GetAttribute(1) == "True";
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        client.Path = reader.Value;
                        bool valid =  File.Exists(client.Path + "\\Everquest2.exe");
                        if (valid || (!valid && MessageBox.Show("Everquest2.exe not found in the save path, do you want to keep this client?", "Everquest2.exe Not Found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK))
                        {
                            client.LastSetting = client.GetLastSet();
                            EQ2EmuLauncher.AddClient(client);
                        }
                    }
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "LiveClientUseLauncher")
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                        EQ2EmuLauncher.UseLauncher = reader.Value == "True";
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Account")
                {
                    Account act = new Account();
                    act.Username = reader.GetAttribute(0);
                    act.Password = reader.GetAttribute(1);
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        act.Name = reader.Value;
                        EQ2EmuLauncher.AddAccount(act);
                    }
                }

                
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Character")
                {
                    Character c = new Character();
                    c.Account = reader.GetAttribute(0);
                    c.World = reader.GetAttribute(1);
                    c.CharacterName = reader.GetAttribute(2);
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        c.Name = reader.Value;
                        EQ2EmuLauncher.AddCharacter(c);
                    }
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "SelectedClient")
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                        EQ2EmuLauncher.LastClient = int.Parse(reader.Value);
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "SelectedAccount")
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                        EQ2EmuLauncher.LastAccount = int.Parse(reader.Value);
                }
            }
            reader.Close();
        }

        public static void Save(List<Client> clients, List<Account> accounts, List<Character> characters, int SelectedClient, int SelectedAccount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create("settings.xml", settings);
            writer.WriteStartDocument();
            writer.WriteComment("EQ2EmuLauncher settings file, used to store clients and accounts for the launcher to use");

            writer.WriteStartElement("EQ2EmuLauncher");
            foreach (Client client in clients)
            {
                writer.WriteStartElement("Client");
                writer.WriteAttributeString("Name", client.Name);
                writer.WriteAttributeString("IsLiveClient", client.IsLiveClient.ToString());
                writer.WriteString(client.Path);
                writer.WriteEndElement();
            }
            
            writer.WriteElementString("LiveClientUseLauncher", EQ2EmuLauncher.UseLauncher.ToString());

            foreach (Account act in accounts)
            {
                writer.WriteStartElement("Account");
                writer.WriteAttributeString("UserName", act.Username);
                writer.WriteAttributeString("Password", act.Password);
                writer.WriteString(act.Name);
                writer.WriteEndElement();
            }

            foreach (Character c in characters)
            {
                writer.WriteStartElement("Character");
                writer.WriteAttributeString("AccountNickName", c.Account);
                writer.WriteAttributeString("World", c.World);
                writer.WriteAttributeString("CharacterName", c.CharacterName);
                writer.WriteString(c.Name);
                writer.WriteEndElement();
            }

            writer.WriteElementString("SelectedClient", SelectedClient.ToString());
            writer.WriteElementString("SelectedAccount", SelectedAccount.ToString());

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        public static string GetNews()
        {
            string html;
            html = "<html>" +
                   "<style>" +
                   "body { color:white; background-color: #460A0A; }" + /* #3C3C3A - first, #460A0A - second,  #712C0D - third*/
                   "div.title { color:blue; font-size:32px; }" +
                   "div.post { font-size:12px; }" +
                   "a:link { color:#0099CC; text-decoration:none; }" +
                   "a:visited { color:#0099CC; text-decoration:none; }" +
                   "a:hover { color:#0099CC; text-decoration:none; }" +
                   "a:active { color:#0099CC; text-decoration:none; }" +
                   "hr.line { height:1px; color:#0099CC; }" +
                   "</style>" +
                   "<body>";

            try
            {
                XmlReader reader = XmlReader.Create("http://www.eq2emulator.net/phpBB3/feed.php?f=2");
                reader.Read();

                if (reader.Value == "version=\"1.0\" encoding=\"UTF-8\"")
                {
                    SyndicationFeed feed = SyndicationFeed.Load(reader);

                    foreach (SyndicationItem item in feed.Items)
                    {
                        html += "<div class=\"title\">";
                        html += "<a href=\"";
                        XmlQualifiedName name = new XmlQualifiedName("base", "http://www.w3.org/XML/1998/namespace");
                        html += item.Content.AttributeExtensions[name];
                        html += "\">";
                        html += item.Title.Text.Substring(25); // Removes the "News and Announcements • " from the title
                        html += "</a>";
                        html += "</div>";

                        html += "<hr class=\"line\" />";

                        html += "<div class=\"post\">";
                        html += item.PublishDate.ToString("f");
                        html += " | ";
                        html += item.Authors[0].Name;
                        html += "</div>";


                        html += "<br/>";
                        html += "<p>";
                        html += (item.Content as TextSyndicationContent).Text;
                        html += "</p>";
                    }
                }
                else
                {
                    html += "<div class=\"title\">Web request error:</div><div class=\"post\">DTDProcessing is prohibited!</div>";
                }
                html += "</body></html>";
            }
            catch (WebException e)
            {
                html += "<div class=\"title\">Web request error:</div><div class=\"post\">" + e.Message + "</div>";
                html += "</body></html>";
            }
            
            return html;
        }
    }
}

/* Sample XML File
 * <Client Name="SF - 1028" IsLiveClient="False" LastSet="Local">C:/EQ2 SF</Client>
 * <Client Name="DoV - 1096" IsLiveClient="False" LastSet="EQ2Emu">C:/EQ2 DoV</Client>
 * <Client Name="CoE - 1208" IsLiveClient="False" LastSet="Custom">C:/EQ2 CoE</Client>
 * <Client Name="Live" IsLiveClient="True" LastSet="Live">C:/EQ2 Live</Client>
 * 
 * <LiveClientUseLauncher>False</LiveClientUseLauncher>
 * 
 * <Account UserName="UserName" Password="Password">Name</Account>
 * 
 * <Character AccountNickName="username" World="server" CharacterName="name">Name</Character>
 */
