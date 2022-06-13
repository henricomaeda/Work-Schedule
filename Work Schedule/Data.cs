using System;
using System.IO;
using System.Windows.Forms;

namespace Job_Scheduling
{
    internal class Data
    {
        private readonly static MessageBoxButtons buttons = MessageBoxButtons.OK;
        private readonly static MessageBoxIcon icon = MessageBoxIcon.Error;
        private static bool darkmode = false;

        public static bool Darkmode(bool activated = true, bool load = false)
        {
            if (load == false)
            {
                try
                {
                    string folderPath = @"C:\Work Schedule";
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                    StreamWriter writer = new StreamWriter(@"C:\Work Schedule\darkmode.txt");

                    darkmode = activated;
                    writer.WriteLine(darkmode);
                    writer.Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    string filePath = @"C:\Work Schedule\darkmode.txt";

                    if (!File.Exists(filePath)) Darkmode(activated, false);
                    else
                    {
                        StreamReader reader = new StreamReader(filePath);
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            darkmode = bool.Parse(line);
                            line = reader.ReadLine();
                        }

                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "", buttons, icon);
                }
            }

            return darkmode;
        }

        public static void Load()
        {

        }

        public static void Save()
        {

        }
    }
}
