//using Enigma_Machine.Code;
//using Enigma_Machine.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Enigma_Machine.Code;

namespace Client_ZI
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();   
        }
         
        private void ChooseFolder(TextBox tbResult)
        {  
            DialogResult result = fbdChooseFolder.ShowDialog();
            if (result == DialogResult.OK)

                tbResult.Text = fbdChooseFolder.SelectedPath;
        }

        private void btnBrowseFileToEncode_Click(object sender, EventArgs e)
        {
            ChooseFolder(tbDestEncodeFolder);
        }
        

        private void BtnBrowseFileToDecode_Click(object sender, EventArgs e)//
        {
            if (client.GetFileInstance().rc4_checked)
                ofdChooseFile.Filter = "(*.rc4)|*.rc4|(*.bmp)|*.bmp|All files (*.*)|*.*";
            else if (client.GetFileInstance().tea_checked)
                ofdChooseFile.Filter = "(*.tea)|*.tea|All files (*.*)|*.*";
            else
                ofdChooseFile.Filter = "(*Cbc.tea)|*Cbc.tea|All files (*.*)|*.*";
            DialogResult result = ofdChooseFile.ShowDialog();
            if (result == DialogResult.OK)
                tbDecodeFile.Text += ofdChooseFile.FileName + "\r\n";
        }

        private void BtnBrowseDecodeDestFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder(tbDestDecodeFolder);
        }

        private void BtnDecodeFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbDestDecodeFolder.Text))
                try
                {
                    var fs = client.GetFileInstance();
                    if (client.GetRC4Instance().Key == null && fs.rc4_checked) //these are only checks, let there be Get...Instance();
                    {
                        MessageBox.Show("Key is not set for RC4 Decoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (client.GetTEAInstance().Key == null && fs.tea_checked)
                    {
                        MessageBox.Show("Key is not set for TEA Decoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (client.GetCBCInstance().Keys == null && client.GetCBCInstance().IV == null && fs.cbc_tea_checked)
                    {
                        MessageBox.Show("Key or IV are not set for TEA_CBC Decoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string str = tbDecodeFile.Text;
                    string path = str.Substring(0, str.Length - 2);
                    //does str tbEncodePath.Text contain  \r\n sequence two times? Or simply, is it one path to one file
                    int index1 = str.IndexOf("\r\n");
                    int index2 = str.IndexOf("\r\n", index1 + 2);

                    if (index1 >= 0 && index2 >= 0)
                    {
                        //splits string after every "\r\n"
                        string[] PathLines = tbDecodeFile.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        Array.Resize(ref PathLines, PathLines.Length - 1); //da se izgubi zadnji ""

                        Parallel_Writing(PathLines, fs.Number_of_Threads);

                        MessageBox.Show("Successful decoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (!File.Exists(path))
                    {
                        MessageBox.Show("Invalid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string outputFileName = client.DecodeFile(path, tbDestDecodeFolder.Text);

                    bool valid = false;

                    if (outputFileName.Length != 0)
                        valid = client.IsValidCrc32(outputFileName);

                    if (outputFileName.Length != 0 && valid)
                        MessageBox.Show("Successful decoding and the file is validated by the CRC!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //TODO
                    else if (outputFileName.Length != 0 && valid == false)
                        MessageBox.Show("Successful decoding but the file is not valided by CRC!\nThe original file doesn't match or original the file is lost!", "Success with warnings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("Invalid file or directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnbrowseEncodePath_Click(object sender, EventArgs e)//
        {

            if (client.GetFileInstance().rc4_checked)
                ofdChooseFile.Filter = "(*.txt)|*.txt|(*.bmp)|*.bmp|All files (*.*)|*.*";
            else if (client.GetFileInstance().tea_checked)
                ofdChooseFile.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
            else
                ofdChooseFile.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = ofdChooseFile.ShowDialog();
            if (result == DialogResult.OK)
                tbEncodePath.Text += ofdChooseFile.FileName + "\r\n";
        }

        private void BtnCodeFilesFromDirectory_Click(object sender, EventArgs e)
        {
           
            if (Directory.Exists(tbDestEncodeFolder.Text))
                try
                {
                    if (client.GetRC4Key() == null && client.GetFileInstance().rc4_checked)
                    {
                        MessageBox.Show("Key is not set for RC4 Encoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (client.GetTEAInstance().Key == null && client.GetFileInstance().tea_checked)
                    {
                        MessageBox.Show("Key is not set for TEA Encoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (client.GetCBCInstance().Keys == null && client.GetCBCInstance().IV == null && client.GetFileInstance().cbc_tea_checked)
                    {
                        MessageBox.Show("Key or IV are not set for TEA_CBC Encoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string str = tbEncodePath.Text;
                    string path = str.Substring(0, str.Length - 2);
                    //does str tbEncodePath.Text contain  \r\n sequence two times? Or simply, is it one path to one file
                    int index1 = str.IndexOf("\r\n");
                    int index2 = str.IndexOf("\r\n", index1 + 2);

                    if (index1 >= 0 && index2 >= 0)
                    {
                        //splits string after every "\r\n"
                        string[] PathLines = tbEncodePath.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        Array.Resize(ref PathLines, PathLines.Length - 1); //da se izgubi zadnji ""

                        Parallel_Loading(PathLines, client.GetFileInstance().Number_of_Threads);

                        MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (!File.Exists(path))
                    {
                        MessageBox.Show("Invalid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    client.SetOutputDirectory(tbDestEncodeFolder.Text);
                    client.EncodeFileFromPath(path);

                    MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            else
                MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSetKey_Click(object sender, EventArgs e)
        {
            if (tbKey.Text.Length == 0)
            {
                MessageBox.Show("Key length is 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButton1.Checked)
            {
                // var rc4Encrypt = //RC4.GetInstance();
                client.SetRC4Key(tbKey.Text);// = tbKey.Text; //PROVERI
            }
            else
            {
                
                byte[] target = Encoding.Unicode.GetBytes(tbKey.Text);
                if (target.Length % 4 != 0)
                    MessageBox.Show("Invalid key for the Tea algorithm!\nPlease try one with even symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    uint[] key = new uint[target.Length / 4];
                    Buffer.BlockCopy(target, 0, key, 0, target.Length);
                    client.SetTEAKey(key);

                    client.SetCBCKey(Array.ConvertAll(key, x => Convert.ToInt64(x)));
                   //client.GetCBCInstance().Keys = Array.ConvertAll(key, x => Convert.ToInt64(x));
                }
            }

        }
        private void Enigma_Machine_Click(object sender, EventArgs e)
        {
            new Manager();
           // //Form enigma = new Enigma_Window();
           //// enigma.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e) //do not delete
        {

        }

        private void btnGenRnd_Click(object sender, EventArgs e)
        {
            tbIV.Text = "";
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            for (int i = 0; i < 2; i++)
            {
                byte[] buffer = new byte[8];
                rng.GetBytes(buffer);
                long randomNumber = BitConverter.ToInt64(buffer, 0);
                tbIV.Text += randomNumber.ToString();
            }
        }
        private void EncriptionAlgorythm_CheckedChanged(object sender, EventArgs e)  //radiobutton1_CheckedChanged
        {
            if (radioButton1.Checked)
            {
                groupBox4.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                btnSetIV.Enabled = false;
                client.rc4_check(true);
                client.tea_check(false);
                client.cbc_tea_check(false);
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox4.Enabled = true;
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                btnSetIV.Enabled = false;      
                client.rc4_check(false);
                client.tea_check(true);
                client.cbc_tea_check(false);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox4.Enabled = false;
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
                btnSetIV.Enabled = true;        
                client.rc4_check(false);               
                client.tea_check(false);               
                client.cbc_tea_check(true);
            }
        }

        private void btnSetIV_Click(object sender, EventArgs e)
        {
            if (tbIV.Text.Length < 16)
            {
                MessageBox.Show("Initialization Vector needs to have at least 16 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            long[] IV = new long[2];
            string half = tbIV.Text.Substring(0, tbIV.Text.Length / 2);
            string secondHalf = tbIV.Text.Substring(tbIV.Text.Length / 2, tbIV.Text.Length / 2);
            byte[] byte_arr = Encoding.ASCII.GetBytes(half);

            IV[0] = BitConverter.ToInt64(byte_arr, 0);
            byte_arr = Encoding.ASCII.GetBytes(secondHalf);
            IV[1] = BitConverter.ToInt64(byte_arr, 0);
            //client.GetCBCInstance().IV = null;
            client.SetCBCIV(null);
            //client.GetCBCInstance().IV = IV;
            client.SetCBCIV(IV);
        }
        
        private void btnCbcEnc_Click(object sender, EventArgs e)
        {

            var cbcc = client.GetCBCInstance();
            if (tbKey.Text.Length == 0 || cbcc.IV == null && client.GetFileInstance().cbc_tea_checked)
            {
                MessageBox.Show("Key or IV are not set for TEA_CBC Encoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbOrgText.Text.Length == 0)
            {
                MessageBox.Show("Type in some text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long[] IV = new long[2];
            string half = tbIV.Text.Substring(0, tbIV.Text.Length / 2);
            string secondHalf = tbIV.Text.Substring(tbIV.Text.Length / 2, tbIV.Text.Length / 2);
            //cbcc.IV = null;
            client.SetCBCIV(null);
            //cbcc.IV = IV;
            client.SetCBCIV(IV);

            //var TEA = client.GetTEAInstance();
            byte[] target = Encoding.Unicode.GetBytes(tbKey.Text);
            if (target.Length % 4 != 0)
            {
                MessageBox.Show("Invalid key for the Tea algorithm!\nPlease try one with even symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            else
            {
                uint[] key = new uint[target.Length / 4];
                Buffer.BlockCopy(target, 0, key, 0, target.Length);
                //TEA.Key = key;
                client.SetTEAKey(key);

                //cbcc.Keys = Array.ConvertAll(key, x => Convert.ToInt64(x));
                client.SetCBCKey(Array.ConvertAll(key, x => Convert.ToInt64(x)));
            }
            //cbcc.EncryptedText = new List<long>().ToArray(); //ToArray I had to add
            client.NewEncryptedText();
            //var cbc = client.GetCBCInstance();
            //cbc.encryptedTexts.Clear(); //PROVERITI
            client.ClearEncryptedTexts();

            tbEncText.Text = Parallelize_Encoding(client.GetFileInstance().Number_of_Threads);

        }

        
        private void btnCbcDec_Click(object sender, EventArgs e) 
        {
            if (client.GetCBCInstance().Keys == null && client.GetCBCInstance().IV == null && client.GetFileInstance().cbc_tea_checked)
            {
                MessageBox.Show("Key or IV are not set for TEA_CBC Decoding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbOrgText.Text.Length == 0)
            {
                MessageBox.Show("Type in some text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbDecText.Text = client.Dec();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = 1;
            }
            //client.GetFileInstance().Number_of_Threads = (int)numericUpDown1.Value;
            client.Set_Number_of_Threads((int)numericUpDown1.Value);
            lblNumberOfThreds.Text = "Number of threads are: " + ((int)numericUpDown1.Value).ToString();
        }

        public void Parallel_Loading(string[] PathLines,int Number_of_Threads)
        {
            int numThreads = Number_of_Threads;

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = numThreads;

            Parallel.ForEach(PathLines, options, line =>
            {
                if (!File.Exists(line))
                {
                    MessageBox.Show("Invalid file path:\n" + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client.SetOutputDirectory(tbDestEncodeFolder.Text);
                client.EncodeFileFromPath(line);

            });
        }
        public string Parallelize_Encoding(int BROJ_NITI) 
        {
            string encoded = String.Empty;
            string org_text = tbOrgText.Text;
            int n = org_text.Length;
            int i = 0;
            for (; i == 0 || i < n;)
            {
                // create a list of delegate methods to invoke in parallel
                List<Action> actions = new List<Action>();

                if (i + 8 >= n)
                {
                    actions.Add(() => encoded += client.ENC_DEC(org_text.Substring(i, n - i)));
                }
                else
                {
                    actions.Add(() => encoded += client.ENC_DEC(org_text.Substring(i, 8)));
                }

                // invoke the delegate methods in parallel, using numThreads threads
                Parallel.Invoke(new ParallelOptions { MaxDegreeOfParallelism = BROJ_NITI }, actions.ToArray());

                i += 8;
            }
            return encoded.ToString();
        }

        public void Parallel_Writing(string[] PathLines, int Number_of_Threads)
        {
            int numThreads = Number_of_Threads;

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = numThreads;

            Parallel.ForEach(PathLines, options, line =>
            {
                if (!File.Exists(line))
                {
                    MessageBox.Show("Invalid file path:\n" + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client.DecodeFile(line, tbDestDecodeFolder.Text);
            });
        }
    }
}
