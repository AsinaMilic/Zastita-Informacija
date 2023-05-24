
namespace Client_ZI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowseFileToEncode = new System.Windows.Forms.Button();
            this.tbDestEncodeFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCodeFilesFromDirectory = new System.Windows.Forms.Button();
            this.btnbrowseEncodePath = new System.Windows.Forms.Button();
            this.tbEncodePath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDecodeFile = new System.Windows.Forms.Button();
            this.btnBrowseDecodeDestFolder = new System.Windows.Forms.Button();
            this.tbDestDecodeFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseFileToDecode = new System.Windows.Forms.Button();
            this.tbDecodeFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnSetKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Enigma_Machine = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.btnSetIV = new System.Windows.Forms.Button();
            this.btnGenRnd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOrgText = new System.Windows.Forms.TextBox();
            this.tbEncText = new System.Windows.Forms.TextBox();
            this.tbDecText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCbcDec = new System.Windows.Forms.Button();
            this.btnCbcEnc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfThreds = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(649, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Encryption algorithms";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnBrowseFileToEncode);
            this.groupBox3.Controls.Add(this.tbDestEncodeFolder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnCodeFilesFromDirectory);
            this.groupBox3.Controls.Add(this.btnbrowseEncodePath);
            this.groupBox3.Controls.Add(this.tbEncodePath);
            this.groupBox3.Location = new System.Drawing.Point(45, 307);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(446, 383);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encrypt Files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Destination Folder:";
            // 
            // btnBrowseFileToEncode
            // 
            this.btnBrowseFileToEncode.Location = new System.Drawing.Point(330, 208);
            this.btnBrowseFileToEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFileToEncode.Name = "btnBrowseFileToEncode";
            this.btnBrowseFileToEncode.Size = new System.Drawing.Size(93, 66);
            this.btnBrowseFileToEncode.TabIndex = 9;
            this.btnBrowseFileToEncode.Text = "Browse";
            this.btnBrowseFileToEncode.UseVisualStyleBackColor = true;
            this.btnBrowseFileToEncode.Click += new System.EventHandler(this.btnBrowseFileToEncode_Click);
            // 
            // tbDestEncodeFolder
            // 
            this.tbDestEncodeFolder.Location = new System.Drawing.Point(43, 208);
            this.tbDestEncodeFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbDestEncodeFolder.Multiline = true;
            this.tbDestEncodeFolder.Name = "tbDestEncodeFolder";
            this.tbDestEncodeFolder.Size = new System.Drawing.Size(273, 66);
            this.tbDestEncodeFolder.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Files to Encrypt:";
            // 
            // btnCodeFilesFromDirectory
            // 
            this.btnCodeFilesFromDirectory.Location = new System.Drawing.Point(69, 311);
            this.btnCodeFilesFromDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCodeFilesFromDirectory.Name = "btnCodeFilesFromDirectory";
            this.btnCodeFilesFromDirectory.Size = new System.Drawing.Size(316, 34);
            this.btnCodeFilesFromDirectory.TabIndex = 3;
            this.btnCodeFilesFromDirectory.Text = "Encrypt File/Files";
            this.btnCodeFilesFromDirectory.UseVisualStyleBackColor = true;
            this.btnCodeFilesFromDirectory.Click += new System.EventHandler(this.BtnCodeFilesFromDirectory_Click);
            // 
            // btnbrowseEncodePath
            // 
            this.btnbrowseEncodePath.Location = new System.Drawing.Point(330, 65);
            this.btnbrowseEncodePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowseEncodePath.Name = "btnbrowseEncodePath";
            this.btnbrowseEncodePath.Size = new System.Drawing.Size(93, 77);
            this.btnbrowseEncodePath.TabIndex = 6;
            this.btnbrowseEncodePath.Text = "Browse";
            this.btnbrowseEncodePath.UseVisualStyleBackColor = true;
            this.btnbrowseEncodePath.Click += new System.EventHandler(this.BtnbrowseEncodePath_Click);
            // 
            // tbEncodePath
            // 
            this.tbEncodePath.Location = new System.Drawing.Point(43, 65);
            this.tbEncodePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbEncodePath.Multiline = true;
            this.tbEncodePath.Name = "tbEncodePath";
            this.tbEncodePath.Size = new System.Drawing.Size(273, 77);
            this.tbEncodePath.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDecodeFile);
            this.groupBox4.Controls.Add(this.btnBrowseDecodeDestFolder);
            this.groupBox4.Controls.Add(this.tbDestDecodeFolder);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnBrowseFileToDecode);
            this.groupBox4.Controls.Add(this.tbDecodeFile);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(534, 307);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(468, 383);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decode File";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnDecodeFile
            // 
            this.btnDecodeFile.Location = new System.Drawing.Point(72, 311);
            this.btnDecodeFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecodeFile.Name = "btnDecodeFile";
            this.btnDecodeFile.Size = new System.Drawing.Size(316, 33);
            this.btnDecodeFile.TabIndex = 4;
            this.btnDecodeFile.Text = "Decode File/Files";
            this.btnDecodeFile.UseVisualStyleBackColor = true;
            this.btnDecodeFile.Click += new System.EventHandler(this.BtnDecodeFile_Click);
            // 
            // btnBrowseDecodeDestFolder
            // 
            this.btnBrowseDecodeDestFolder.Location = new System.Drawing.Point(340, 208);
            this.btnBrowseDecodeDestFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseDecodeDestFolder.Name = "btnBrowseDecodeDestFolder";
            this.btnBrowseDecodeDestFolder.Size = new System.Drawing.Size(93, 66);
            this.btnBrowseDecodeDestFolder.TabIndex = 10;
            this.btnBrowseDecodeDestFolder.Text = "Browse";
            this.btnBrowseDecodeDestFolder.UseVisualStyleBackColor = true;
            this.btnBrowseDecodeDestFolder.Click += new System.EventHandler(this.BtnBrowseDecodeDestFolder_Click);
            // 
            // tbDestDecodeFolder
            // 
            this.tbDestDecodeFolder.Location = new System.Drawing.Point(41, 208);
            this.tbDestDecodeFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbDestDecodeFolder.Multiline = true;
            this.tbDestDecodeFolder.Name = "tbDestDecodeFolder";
            this.tbDestDecodeFolder.Size = new System.Drawing.Size(281, 66);
            this.tbDestDecodeFolder.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination Folder:";
            // 
            // btnBrowseFileToDecode
            // 
            this.btnBrowseFileToDecode.Location = new System.Drawing.Point(340, 65);
            this.btnBrowseFileToDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFileToDecode.Name = "btnBrowseFileToDecode";
            this.btnBrowseFileToDecode.Size = new System.Drawing.Size(93, 77);
            this.btnBrowseFileToDecode.TabIndex = 6;
            this.btnBrowseFileToDecode.Text = "Browse";
            this.btnBrowseFileToDecode.UseVisualStyleBackColor = true;
            this.btnBrowseFileToDecode.Click += new System.EventHandler(this.BtnBrowseFileToDecode_Click);
            // 
            // tbDecodeFile
            // 
            this.tbDecodeFile.Location = new System.Drawing.Point(41, 65);
            this.tbDecodeFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbDecodeFile.Multiline = true;
            this.tbDecodeFile.Name = "tbDecodeFile";
            this.tbDecodeFile.Size = new System.Drawing.Size(281, 77);
            this.tbDecodeFile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Files to Decode:";
            // 
            // ofdChooseFile
            // 
            this.ofdChooseFile.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(185, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(227, 144);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(211, 19);
            this.tbKey.TabIndex = 14;
            // 
            // btnSetKey
            // 
            this.btnSetKey.Location = new System.Drawing.Point(444, 135);
            this.btnSetKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetKey.Name = "btnSetKey";
            this.btnSetKey.Size = new System.Drawing.Size(98, 36);
            this.btnSetKey.TabIndex = 15;
            this.btnSetKey.Text = "Set Key";
            this.btnSetKey.UseVisualStyleBackColor = true;
            this.btnSetKey.Click += new System.EventHandler(this.BtnSetKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(620, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(293, 86);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption algorythms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Parallel Encoding";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Supports";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Supports BMP files";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButton3.Location = new System.Drawing.Point(205, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TEA-CBC";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "TEA";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RC4";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.EncriptionAlgorythm_CheckedChanged);
            // 
            // Enigma_Machine
            // 
            this.Enigma_Machine.Location = new System.Drawing.Point(685, 734);
            this.Enigma_Machine.Name = "Enigma_Machine";
            this.Enigma_Machine.Size = new System.Drawing.Size(183, 35);
            this.Enigma_Machine.TabIndex = 19;
            this.Enigma_Machine.Text = "Activate Enigma Machine";
            this.Enigma_Machine.UseVisualStyleBackColor = true;
            this.Enigma_Machine.Click += new System.EventHandler(this.Enigma_Machine_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(620, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "CRC checking is activated for all algorithms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(947, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Initialization Vector ";
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(1073, 144);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(242, 19);
            this.tbIV.TabIndex = 23;
            // 
            // btnSetIV
            // 
            this.btnSetIV.Location = new System.Drawing.Point(1326, 137);
            this.btnSetIV.Name = "btnSetIV";
            this.btnSetIV.Size = new System.Drawing.Size(98, 35);
            this.btnSetIV.TabIndex = 24;
            this.btnSetIV.Text = "Set IV";
            this.btnSetIV.UseVisualStyleBackColor = true;
            this.btnSetIV.Click += new System.EventHandler(this.btnSetIV_Click);
            // 
            // btnGenRnd
            // 
            this.btnGenRnd.Location = new System.Drawing.Point(1152, 169);
            this.btnGenRnd.Name = "btnGenRnd";
            this.btnGenRnd.Size = new System.Drawing.Size(75, 23);
            this.btnGenRnd.TabIndex = 25;
            this.btnGenRnd.Text = "Generate IV";
            this.btnGenRnd.UseVisualStyleBackColor = true;
            this.btnGenRnd.Click += new System.EventHandler(this.btnGenRnd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label11.Location = new System.Drawing.Point(1073, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "If length isn\'t good, padding may be added";
            // 
            // tbOrgText
            // 
            this.tbOrgText.Location = new System.Drawing.Point(35, 65);
            this.tbOrgText.Multiline = true;
            this.tbOrgText.Name = "tbOrgText";
            this.tbOrgText.Size = new System.Drawing.Size(242, 54);
            this.tbOrgText.TabIndex = 27;
            // 
            // tbEncText
            // 
            this.tbEncText.Location = new System.Drawing.Point(35, 175);
            this.tbEncText.Multiline = true;
            this.tbEncText.Name = "tbEncText";
            this.tbEncText.ReadOnly = true;
            this.tbEncText.Size = new System.Drawing.Size(242, 54);
            this.tbEncText.TabIndex = 28;
            // 
            // tbDecText
            // 
            this.tbDecText.Location = new System.Drawing.Point(35, 293);
            this.tbDecText.Multiline = true;
            this.tbDecText.Name = "tbDecText";
            this.tbDecText.ReadOnly = true;
            this.tbDecText.Size = new System.Drawing.Size(242, 52);
            this.tbDecText.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCbcDec);
            this.groupBox2.Controls.Add(this.btnCbcEnc);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbEncText);
            this.groupBox2.Controls.Add(this.tbOrgText);
            this.groupBox2.Controls.Add(this.tbDecText);
            this.groupBox2.Location = new System.Drawing.Point(1046, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 383);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TEA-CBC Input/Output";
            // 
            // btnCbcDec
            // 
            this.btnCbcDec.Location = new System.Drawing.Point(311, 175);
            this.btnCbcDec.Name = "btnCbcDec";
            this.btnCbcDec.Size = new System.Drawing.Size(75, 54);
            this.btnCbcDec.TabIndex = 34;
            this.btnCbcDec.Text = "Decode";
            this.btnCbcDec.UseVisualStyleBackColor = true;
            this.btnCbcDec.Click += new System.EventHandler(this.btnCbcDec_Click);
            // 
            // btnCbcEnc
            // 
            this.btnCbcEnc.Location = new System.Drawing.Point(311, 65);
            this.btnCbcEnc.Name = "btnCbcEnc";
            this.btnCbcEnc.Size = new System.Drawing.Size(75, 54);
            this.btnCbcEnc.TabIndex = 33;
            this.btnCbcEnc.Text = "Encode";
            this.btnCbcEnc.UseVisualStyleBackColor = true;
            this.btnCbcEnc.Click += new System.EventHandler(this.btnCbcEnc_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 261);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Decrypted Text:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Encrypted Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Original Text:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.label17.Location = new System.Drawing.Point(610, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(329, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "The number of threads you wiant to be executed in parallel:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AllowDrop = true;
            this.numericUpDown1.Location = new System.Drawing.Point(698, 260);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblNumberOfThreds
            // 
            this.lblNumberOfThreds.AutoSize = true;
            this.lblNumberOfThreds.Location = new System.Drawing.Point(694, 290);
            this.lblNumberOfThreds.Name = "lblNumberOfThreds";
            this.lblNumberOfThreds.Size = new System.Drawing.Size(124, 13);
            this.lblNumberOfThreds.TabIndex = 37;
            this.lblNumberOfThreds.Text = "Number of threads are: 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Info;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(485, 23);
            this.label16.TabIndex = 38;
            this.label16.Text = "Before you start, update the Service Reference and set Client_ZI as startup proje" +
    "ct";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 809);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNumberOfThreds);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGenRnd);
            this.Controls.Add(this.btnSetIV);
            this.Controls.Add(this.tbIV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Enigma_Machine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Encryption";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCodeFilesFromDirectory;
        private System.Windows.Forms.Button btnbrowseEncodePath;
        private System.Windows.Forms.TextBox tbEncodePath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDecodeFile;
        private System.Windows.Forms.Button btnBrowseDecodeDestFolder;
        private System.Windows.Forms.TextBox tbDestDecodeFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseFileToDecode;
        private System.Windows.Forms.TextBox tbDecodeFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdChooseFolder;
        private System.Windows.Forms.OpenFileDialog ofdChooseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnSetKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Enigma_Machine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBrowseFileToEncode;
        private System.Windows.Forms.TextBox tbDestEncodeFolder;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Button btnSetIV;
        private System.Windows.Forms.Button btnGenRnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOrgText;
        private System.Windows.Forms.TextBox tbEncText;
        private System.Windows.Forms.TextBox tbDecText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCbcDec;
        private System.Windows.Forms.Button btnCbcEnc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNumberOfThreds;
        private System.Windows.Forms.Label label16;
    }
}

