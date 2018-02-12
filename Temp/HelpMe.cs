using MetroFramework.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public static class HelpMe
    {
        // Hard coded Levels
        public static string[] levels = { "Level 7","Level 6", "Level 5" };

        // String Processing function to get initials
        public static string GetInitials(string names, string separator)
        {
            // Extract the first character out of each block of non-whitespace
            Regex extractInitials = new Regex(@"\s*([^\s])[^\s]*\s*");
            return extractInitials.Replace(names, "$1" + separator).ToUpper();
        }

        // String Processig from "L7" to "Level 7"
        public static string GetFullForm(string sf)
        {
            switch(sf)
            {
                case "L7":
                    return "Level 7";
                case "L6":
                    return "Level 6";
                case "L5":
                    return "Level 5";
                case "GD":
                    return "Graduate Diploma";
            }

            return "Not Found";
        }

        // Save Json data to File with extension 
        public static void SaveFileNow(string jsonstr,string fileextension)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                bool extpres = Path.GetExtension(sfd.FileName).Equals("") ? false : true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName + (extpres?"":"."+fileextension), jsonstr);
                }           
            }
        }

        // Open File Function which open file choser
        public static string OpenFileNow(string extension)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    String data = File.ReadAllText(ofd.FileName);
                    if(Path.GetExtension(ofd.FileName).Equals("."+extension))
                    {
                        Console.Write(data);
                    }else
                    {
                        new MsgBox("Extension do not match "+ Path.GetExtension(ofd.FileName));
                    }
                    return data;
                }
                else
                {
                    return null;
                }

            }
        }

        // Serialize object to Json 
        public static string GetJson(object s)
        {
            try
            {
                return JsonConvert.SerializeObject(s, Formatting.None,
                    new JsonSerializerSettings
                    {
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
            }
            catch
            {
                return null;
            }
        }

        // List Data From Json 
        public static List<TType> GetDataFromJson<TType>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TType>>(json);
            }
            catch
            {
                return new List<TType>();
            }
        }

        // Generate MD5 Hash from
        public static string CalculateMD5Hash(string input)

        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {
                sb.Append(hash[i].ToString("X2"));
            }

            Console.WriteLine("CalculateMd5 >>>"+sb.ToString());
            return sb.ToString();

        }

        // Convert String to Binart
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        //Convert Binary data to string
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        // Convert String to md5 hash then comvert it into binay data
        public static byte[] Md5toBinary(string str)
        {
            string data = CalculateMD5Hash(str);
            byte[] xxx = Encoding.ASCII.GetBytes(data);
            Console.WriteLine();
            Console.WriteLine(xxx.Length+"  <<<<<<<<<<"+ str);
            return xxx;
        }

        // Convert binary data to Md5 Hash
        public static string BinarytoMd5(byte[] arr)
        {
            return Encoding.ASCII.GetString(arr);
        }

        // Validate TextBox data for number
        public static void ValidatorTBn(this MetroTextBox x,ErrorProvider errorProvider,Object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(x.Text, "[^0-9]"))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "Please enter numbers only");
            }
            else
           if (string.IsNullOrEmpty(x.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(x, null);
            }
        }

        // Validate TextBox data for alphabet
        public static void ValidatorTBa(this MetroTextBox x, ErrorProvider errorProvider, Object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(x.Text, "[^a-zA-Z0-9 ]"))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "Please enter alphabets only");
            }
            else
           if (string.IsNullOrEmpty(x.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(x, null);
            }
        }
        
        // Validate TextBox data for checkbox
        public static void ValidatorCB(this MetroComboBox x, ErrorProvider errorProvider, Object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(x.Text, "[^a-zA-Z0-9- ]"))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "Please enter alphabets only");
            }
            else
           if (string.IsNullOrEmpty(x.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(x, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(x, null);
            }
        }

        // Validate TextBox data for email
        public static void ValidatorEmail(this MetroTextBox x,ErrorProvider ep,Object sender,CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(x.Text);
            if (match.Success)
            {
                e.Cancel = false;
                ep.SetError(x, null);
            }
            else
            {
                e.Cancel = true;
                ep.SetError(x, "Invalid Email Id");
            }
        }
    }


}

