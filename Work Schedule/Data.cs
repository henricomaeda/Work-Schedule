using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Job_Scheduling
{
    internal class Data
    {
        private static bool darkmode = false;

        public static int[] id;
        public static string[] name;
        public static string[] work;
        public static string[] details;
        public static string[] financialDetails;
        public static string[] created;
        public static string[] deadline;
        public static string[] period;
        public static string[] status;

        public static void Add(string n, string w, string d, string f, string c, string dl, string p, string s)
        {
            try
            {
                List<int> idList = new List<int>();
                List<string> nameList = new List<string>();
                List<string> workList = new List<string>();
                List<string> detailsList = new List<string>();
                List<string> financialDetailsList = new List<string>();
                List<string> createdList = new List<string>();
                List<string> deadlineList = new List<string>();
                List<string> periodList = new List<string>();
                List<string> statusList = new List<string>();

                if (id != null)
                {
                    foreach (int idTemp in id)
                    {
                        idList.Add(idTemp);
                    }

                    idList.Add(id.Last() + 1);

                    foreach (string nameTemp in name)
                    {
                        nameList.Add(nameTemp);
                    }

                    foreach (string workTemp in work)
                    {
                        workList.Add(workTemp);
                    }

                    foreach (string detailsTemp in details)
                    {
                        detailsList.Add(detailsTemp);
                    }

                    foreach (string financialDetailsTemp in financialDetails)
                    {
                        financialDetailsList.Add(financialDetailsTemp);
                    }

                    foreach (string createdTemp in created)
                    {
                        createdList.Add(createdTemp);
                    }

                    foreach (string deadlineTemp in deadline)
                    {
                        deadlineList.Add(deadlineTemp);
                    }

                    foreach (string periodTemp in period)
                    {
                        periodList.Add(periodTemp);
                    }

                    foreach (string statusTemp in status)
                    {
                        statusList.Add(statusTemp);
                    }
                }
                else idList.Add(0);

                nameList.Add(n);
                workList.Add(w);
                detailsList.Add(d);
                financialDetailsList.Add(f);
                createdList.Add(c);
                deadlineList.Add(dl);
                periodList.Add(p);
                statusList.Add(s);

                id = idList.ToArray();
                name = nameList.ToArray();
                work = workList.ToArray();
                details = detailsList.ToArray();
                financialDetails = financialDetailsList.ToArray();
                created = createdList.ToArray();
                deadline = deadlineList.ToArray();
                period = periodList.ToArray();
                status = statusList.ToArray();
            }
            catch { }
        }

        public static void Update(int i, string n, string w, string d, string f, string c, string dl, string p, string s)
        {
            try
            {
                if (i >= 0)
                {
                    name[i] = n;
                    work[i] = w;
                    details[i] = d;
                    financialDetails[i] = f;
                    created[i] = c;
                    deadline[i] = dl;
                    period[i] = p;
                    status[i] = s;
                }
            }
            catch { }
        }

        public static void Load()
        {
            if (id == null)
            {
                string filePath = @"C:\Work Schedule\database.txt";
                if (File.Exists(filePath))
                {
                    try
                    {
                        List<int> idList = new List<int>();
                        List<string> nameList = new List<string>();
                        List<string> workList = new List<string>();
                        List<string> detailsList = new List<string>();
                        List<string> financialDetailsList = new List<string>();
                        List<string> createdList = new List<string>();
                        List<string> deadlineList = new List<string>();
                        List<string> periodList = new List<string>();
                        List<string> statusList = new List<string>();

                        StreamReader reader = new StreamReader(filePath);
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            string[] content = line.Split('|');
                            idList.Add(int.Parse(Decrypt(content[0])));
                            nameList.Add(Decrypt(content[1]));
                            workList.Add(Decrypt(content[2]));
                            detailsList.Add(Decrypt(content[3]));
                            financialDetailsList.Add(Decrypt(content[4]));
                            createdList.Add(Decrypt(content[5]));
                            deadlineList.Add(Decrypt(content[6]));
                            periodList.Add(Decrypt(content[7]));
                            statusList.Add(Decrypt(content[8]));
                            line = reader.ReadLine();
                        }

                        id = idList.ToArray();
                        name = nameList.ToArray();
                        work = workList.ToArray();
                        details = detailsList.ToArray();
                        financialDetails = financialDetailsList.ToArray();
                        created = createdList.ToArray();
                        deadline = deadlineList.ToArray();
                        period = periodList.ToArray();
                        status = statusList.ToArray();
                        reader.Close();
                    }
                    catch { }
                }
            }
        }

        public static void Save()
        {
            if (name != null)
            {
                try
                {
                    string folderPath = @"C:\Work Schedule";
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                    StreamWriter writer = new StreamWriter(@"C:\Work Schedule\database.txt");

                    for (int count = 0; count < name.Length; count++)
                    {
                        writer.WriteLine(Encrypt(id[count].ToString()) + '|' + Encrypt(name[count].ToString()) + '|' + Encrypt(work[count].ToString()) + '|' + Encrypt(details[count].ToString()) + '|' + Encrypt(financialDetails[count].ToString()) + '|' + Encrypt(created[count].ToString()) + '|' + Encrypt(deadline[count].ToString()) + '|' + Encrypt(period[count].ToString()) + '|' + Encrypt(status[count].ToString()));
                    }

                    writer.Close();
                }
                catch { }
            }
        }

        private static string Encrypt(string textToEncrypt)
        {
            try
            {
                string toReturn = "";

                string publickey = "12345678";
                string secretkey = "87654321";

                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);

                byte[] secretkeyByte = { };
                secretkeyByte = Encoding.UTF8.GetBytes(secretkey);

                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    toReturn = Convert.ToBase64String(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        private static string Decrypt(string textToDecrypt)
        {
            try
            {
                string toReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";

                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);

                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(secretkey);

                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    toReturn = encoding.GetString(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

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
                string filePath = @"C:\Work Schedule\darkmode.txt";

                try
                {
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
                catch { }
            }

            return darkmode;
        }

    }
}
