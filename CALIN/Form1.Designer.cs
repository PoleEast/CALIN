using CALIN.Controls;

namespace CALIN
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            richText_message = new RichTextBox();
            btnCameraConnect = new Button();
            txtCamState = new TextBox();
            btnexit = new Button();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            btnFilter = new Button();
            btnABI = new Button();
            btnAHE = new Button();
            btnBI = new Button();
            btnSaveimg = new Button();
            lbxCam = new ListBox();
            cmbCameraID = new ComboBox();
            label1 = new Label();
            btnCLAHE = new Button();
            ptbyolo = new PictureBox();
            ptbbefore = new PictureBox();
            ptbafter = new PictureEvent();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            btnAllStop = new Button();
            bntResetPos = new Button();
            btnStop = new Button();
            btnRepeat = new Button();
            btnNmove = new Button();
            btnPmove = new Button();
            cboDIST = new TextBox();
            txtMaxVel = new TextBox();
            label12 = new Label();
            label11 = new Label();
            lbworking = new Label();
            txtERR = new TextBox();
            txtspeed = new TextBox();
            txtcommand = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmbIOnode = new ComboBox();
            cmbDRIVERnode = new ComboBox();
            cmb04PInode = new ComboBox();
            CmbCardNo = new ComboBox();
            txtslavenum = new TextBox();
            txtcardnum = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            timer_Inspect = new System.Windows.Forms.Timer(components);
            timer4PI = new System.Windows.Forms.Timer(components);
            timer_repeat = new System.Windows.Forms.Timer(components);
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbyolo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbefore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbafter).BeginInit();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(1016, 39);
            btnStart.Margin = new Padding(2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(176, 88);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // richText_message
            // 
            richText_message.Location = new Point(1016, 131);
            richText_message.Margin = new Padding(2);
            richText_message.Name = "richText_message";
            richText_message.ReadOnly = true;
            richText_message.ScrollBars = RichTextBoxScrollBars.None;
            richText_message.Size = new Size(176, 321);
            richText_message.TabIndex = 1;
            richText_message.Text = "";
            // 
            // btnCameraConnect
            // 
            btnCameraConnect.Location = new Point(765, 459);
            btnCameraConnect.Margin = new Padding(2);
            btnCameraConnect.Name = "btnCameraConnect";
            btnCameraConnect.Size = new Size(217, 66);
            btnCameraConnect.TabIndex = 2;
            btnCameraConnect.Text = "Camera On";
            btnCameraConnect.UseVisualStyleBackColor = true;
            btnCameraConnect.Click += btnCameraConnect_Click;
            // 
            // txtCamState
            // 
            txtCamState.Location = new Point(1016, 468);
            txtCamState.Margin = new Padding(2);
            txtCamState.Name = "txtCamState";
            txtCamState.Size = new Size(176, 27);
            txtCamState.TabIndex = 3;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1016, 497);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(176, 88);
            btnexit.TabIndex = 4;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.ItemSize = new Size(85, 32);
            tabControl2.Location = new Point(23, 11);
            tabControl2.Margin = new Padding(2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(995, 576);
            tabControl2.TabIndex = 45;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnFilter);
            tabPage1.Controls.Add(btnABI);
            tabPage1.Controls.Add(btnAHE);
            tabPage1.Controls.Add(btnBI);
            tabPage1.Controls.Add(btnSaveimg);
            tabPage1.Controls.Add(lbxCam);
            tabPage1.Controls.Add(btnCameraConnect);
            tabPage1.Controls.Add(cmbCameraID);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnCLAHE);
            tabPage1.Controls.Add(ptbyolo);
            tabPage1.Controls.Add(ptbbefore);
            tabPage1.Controls.Add(ptbafter);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(987, 536);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "camera";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(542, 459);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 62);
            btnFilter.TabIndex = 48;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnABI
            // 
            btnABI.Location = new Point(542, 392);
            btnABI.Margin = new Padding(2);
            btnABI.Name = "btnABI";
            btnABI.Size = new Size(111, 62);
            btnABI.TabIndex = 47;
            btnABI.Text = "ABI";
            btnABI.UseVisualStyleBackColor = true;
            btnABI.Click += btnABI_Click;
            // 
            // btnAHE
            // 
            btnAHE.Location = new Point(542, 326);
            btnAHE.Margin = new Padding(2);
            btnAHE.Name = "btnAHE";
            btnAHE.Size = new Size(111, 62);
            btnAHE.TabIndex = 46;
            btnAHE.Text = "AHE";
            btnAHE.UseVisualStyleBackColor = true;
            btnAHE.Click += btnAHE_Click;
            // 
            // btnBI
            // 
            btnBI.Location = new Point(427, 392);
            btnBI.Margin = new Padding(2);
            btnBI.Name = "btnBI";
            btnBI.Size = new Size(111, 62);
            btnBI.TabIndex = 45;
            btnBI.Text = "BI";
            btnBI.UseVisualStyleBackColor = true;
            btnBI.Click += btnBI_Click;
            // 
            // btnSaveimg
            // 
            btnSaveimg.Location = new Point(427, 458);
            btnSaveimg.Margin = new Padding(2);
            btnSaveimg.Name = "btnSaveimg";
            btnSaveimg.Size = new Size(111, 62);
            btnSaveimg.TabIndex = 7;
            btnSaveimg.Text = "Save img";
            btnSaveimg.UseVisualStyleBackColor = true;
            btnSaveimg.Click += btnSaveimg_Click;
            // 
            // lbxCam
            // 
            lbxCam.FormattingEnabled = true;
            lbxCam.ItemHeight = 19;
            lbxCam.Location = new Point(765, 329);
            lbxCam.Margin = new Padding(2);
            lbxCam.Name = "lbxCam";
            lbxCam.Size = new Size(218, 118);
            lbxCam.TabIndex = 6;
            lbxCam.SelectedIndexChanged += lbxCam_SelectedIndexChanged;
            // 
            // cmbCameraID
            // 
            cmbCameraID.FormattingEnabled = true;
            cmbCameraID.Location = new Point(765, 302);
            cmbCameraID.Margin = new Padding(2);
            cmbCameraID.Name = "cmbCameraID";
            cmbCameraID.Size = new Size(218, 27);
            cmbCameraID.TabIndex = 5;
            cmbCameraID.SelectedIndexChanged += cmbCameraID_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(675, 307);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 4;
            label1.Text = "Camera ID";
            // 
            // btnCLAHE
            // 
            btnCLAHE.Location = new Point(427, 326);
            btnCLAHE.Margin = new Padding(2);
            btnCLAHE.Name = "btnCLAHE";
            btnCLAHE.Size = new Size(111, 62);
            btnCLAHE.TabIndex = 3;
            btnCLAHE.Text = "CLAHE";
            btnCLAHE.UseVisualStyleBackColor = true;
            btnCLAHE.Click += btnHE_Click;
            // 
            // ptbyolo
            // 
            ptbyolo.BorderStyle = BorderStyle.FixedSingle;
            ptbyolo.Location = new Point(556, 4);
            ptbyolo.Margin = new Padding(2);
            ptbyolo.Name = "ptbyolo";
            ptbyolo.Size = new Size(417, 231);
            ptbyolo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbyolo.TabIndex = 2;
            ptbyolo.TabStop = false;
            // 
            // ptbbefore
            // 
            ptbbefore.BorderStyle = BorderStyle.FixedSingle;
            ptbbefore.Image = (Image)resources.GetObject("ptbbefore.Image");
            ptbbefore.Location = new Point(4, 4);
            ptbbefore.Name = "ptbbefore";
            ptbbefore.Size = new Size(417, 231);
            ptbbefore.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbefore.TabIndex = 1;
            ptbbefore.TabStop = false;
            // 
            // ptbafter
            // 
            ptbafter.BorderStyle = BorderStyle.FixedSingle;
            ptbafter.Image = null;
            ptbafter.Location = new Point(5, 289);
            ptbafter.Name = "ptbafter";
            ptbafter.Size = new Size(417, 231);
            ptbafter.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbafter.TabIndex = 44;
            ptbafter.TabStop = false;
            ptbafter.ImageChanged += ptbafter_ImageChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl1);
            tabPage2.Controls.Add(cboDIST);
            tabPage2.Controls.Add(txtMaxVel);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(lbworking);
            tabPage2.Controls.Add(txtERR);
            tabPage2.Controls.Add(txtspeed);
            tabPage2.Controls.Add(txtcommand);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cmbIOnode);
            tabPage2.Controls.Add(cmbDRIVERnode);
            tabPage2.Controls.Add(cmb04PInode);
            tabPage2.Controls.Add(CmbCardNo);
            tabPage2.Controls.Add(txtslavenum);
            tabPage2.Controls.Add(txtcardnum);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(987, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "control";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(95, 52);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(277, 265);
            tabControl1.TabIndex = 49;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnAllStop);
            tabPage4.Controls.Add(bntResetPos);
            tabPage4.Controls.Add(btnStop);
            tabPage4.Controls.Add(btnRepeat);
            tabPage4.Controls.Add(btnNmove);
            tabPage4.Controls.Add(btnPmove);
            tabPage4.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 28);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(269, 233);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "04pi Node";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAllStop
            // 
            btnAllStop.Enabled = false;
            btnAllStop.Location = new Point(136, 159);
            btnAllStop.Margin = new Padding(2);
            btnAllStop.Name = "btnAllStop";
            btnAllStop.Size = new Size(128, 73);
            btnAllStop.TabIndex = 51;
            btnAllStop.Text = "All Stop";
            btnAllStop.UseVisualStyleBackColor = true;
            btnAllStop.Click += btnAllStop_Click;
            // 
            // bntResetPos
            // 
            bntResetPos.Enabled = false;
            bntResetPos.Location = new Point(4, 159);
            bntResetPos.Margin = new Padding(2);
            bntResetPos.Name = "bntResetPos";
            bntResetPos.Size = new Size(128, 73);
            bntResetPos.TabIndex = 39;
            bntResetPos.Text = " Reset Pos";
            bntResetPos.UseVisualStyleBackColor = true;
            bntResetPos.Click += bntResetPos_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(136, 82);
            btnStop.Margin = new Padding(2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(128, 73);
            btnStop.TabIndex = 40;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnRepeat
            // 
            btnRepeat.Enabled = false;
            btnRepeat.Location = new Point(4, 82);
            btnRepeat.Margin = new Padding(2);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(128, 73);
            btnRepeat.TabIndex = 2;
            btnRepeat.Text = "Repeat";
            btnRepeat.UseVisualStyleBackColor = true;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnNmove
            // 
            btnNmove.Enabled = false;
            btnNmove.Location = new Point(136, 4);
            btnNmove.Margin = new Padding(2);
            btnNmove.Name = "btnNmove";
            btnNmove.Size = new Size(128, 73);
            btnNmove.TabIndex = 1;
            btnNmove.Text = "Anti-Clockwise";
            btnNmove.UseVisualStyleBackColor = true;
            btnNmove.Click += btnNmove_Click;
            // 
            // btnPmove
            // 
            btnPmove.Enabled = false;
            btnPmove.Location = new Point(4, 4);
            btnPmove.Margin = new Padding(2);
            btnPmove.Name = "btnPmove";
            btnPmove.Size = new Size(128, 73);
            btnPmove.TabIndex = 0;
            btnPmove.Text = "positive movement";
            btnPmove.UseVisualStyleBackColor = true;
            btnPmove.Click += btnPmove_Click;
            // 
            // cboDIST
            // 
            cboDIST.Location = new Point(521, 290);
            cboDIST.Margin = new Padding(2);
            cboDIST.Name = "cboDIST";
            cboDIST.Size = new Size(151, 27);
            cboDIST.TabIndex = 48;
            // 
            // txtMaxVel
            // 
            txtMaxVel.Location = new Point(521, 261);
            txtMaxVel.Margin = new Padding(2);
            txtMaxVel.Name = "txtMaxVel";
            txtMaxVel.Size = new Size(151, 27);
            txtMaxVel.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(474, 296);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 19);
            label12.TabIndex = 46;
            label12.Text = "Dist:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(408, 263);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 19);
            label11.TabIndex = 45;
            label11.Text = "Motor speed:";
            // 
            // lbworking
            // 
            lbworking.AutoSize = true;
            lbworking.Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbworking.ForeColor = Color.Red;
            lbworking.Location = new Point(479, 179);
            lbworking.Margin = new Padding(2, 0, 2, 0);
            lbworking.Name = "lbworking";
            lbworking.Size = new Size(182, 50);
            lbworking.TabIndex = 44;
            lbworking.Text = "Working";
            // 
            // txtERR
            // 
            txtERR.Location = new Point(521, 130);
            txtERR.Margin = new Padding(2, 3, 2, 3);
            txtERR.Name = "txtERR";
            txtERR.ReadOnly = true;
            txtERR.Size = new Size(151, 27);
            txtERR.TabIndex = 22;
            // 
            // txtspeed
            // 
            txtspeed.Location = new Point(521, 86);
            txtspeed.Margin = new Padding(2, 3, 2, 3);
            txtspeed.Name = "txtspeed";
            txtspeed.ReadOnly = true;
            txtspeed.Size = new Size(151, 27);
            txtspeed.TabIndex = 21;
            // 
            // txtcommand
            // 
            txtcommand.Location = new Point(521, 42);
            txtcommand.Margin = new Padding(2, 3, 2, 3);
            txtcommand.Name = "txtcommand";
            txtcommand.ReadOnly = true;
            txtcommand.Size = new Size(151, 27);
            txtcommand.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(472, 135);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 19);
            label10.TabIndex = 36;
            label10.Text = "Error";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(461, 91);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 19);
            label9.TabIndex = 18;
            label9.Text = "Speed";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(430, 47);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 19);
            label8.TabIndex = 35;
            label8.Text = "Command";
            // 
            // cmbIOnode
            // 
            cmbIOnode.FormattingEnabled = true;
            cmbIOnode.Location = new Point(805, 261);
            cmbIOnode.Margin = new Padding(2, 3, 2, 3);
            cmbIOnode.Name = "cmbIOnode";
            cmbIOnode.Size = new Size(151, 27);
            cmbIOnode.TabIndex = 14;
            // 
            // cmbDRIVERnode
            // 
            cmbDRIVERnode.FormattingEnabled = true;
            cmbDRIVERnode.Location = new Point(805, 217);
            cmbDRIVERnode.Margin = new Padding(2, 3, 2, 3);
            cmbDRIVERnode.Name = "cmbDRIVERnode";
            cmbDRIVERnode.Size = new Size(151, 27);
            cmbDRIVERnode.TabIndex = 11;
            // 
            // cmb04PInode
            // 
            cmb04PInode.FormattingEnabled = true;
            cmb04PInode.Location = new Point(805, 173);
            cmb04PInode.Margin = new Padding(2, 3, 2, 3);
            cmb04PInode.Name = "cmb04PInode";
            cmb04PInode.Size = new Size(151, 27);
            cmb04PInode.TabIndex = 10;
            // 
            // CmbCardNo
            // 
            CmbCardNo.FormattingEnabled = true;
            CmbCardNo.Location = new Point(805, 86);
            CmbCardNo.Margin = new Padding(2);
            CmbCardNo.Name = "CmbCardNo";
            CmbCardNo.Size = new Size(151, 27);
            CmbCardNo.TabIndex = 16;
            // 
            // txtslavenum
            // 
            txtslavenum.Location = new Point(805, 130);
            txtslavenum.Margin = new Padding(2, 3, 2, 3);
            txtslavenum.Name = "txtslavenum";
            txtslavenum.ReadOnly = true;
            txtslavenum.Size = new Size(151, 27);
            txtslavenum.TabIndex = 8;
            // 
            // txtcardnum
            // 
            txtcardnum.Location = new Point(805, 42);
            txtcardnum.Margin = new Padding(2, 3, 2, 3);
            txtcardnum.Name = "txtcardnum";
            txtcardnum.ReadOnly = true;
            txtcardnum.Size = new Size(151, 27);
            txtcardnum.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(695, 267);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 13;
            label7.Text = "I/O Node ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(695, 223);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 12;
            label6.Text = "Motor num";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 9;
            label5.Text = "04pi Node ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(695, 135);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 5;
            label4.Text = "Slave num:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(695, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 4;
            label3.Text = "Card No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(695, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 3;
            label2.Text = "Card num:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 36);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(987, 536);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "model";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // timer_Inspect
            // 
            timer_Inspect.Tick += timer_Inspect_Tick;
            // 
            // timer4PI
            // 
            timer4PI.Tick += timer4PI_Tick;
            // 
            // timer_repeat
            // 
            timer_repeat.Tick += timer_repeat_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 584);
            Controls.Add(tabControl2);
            Controls.Add(btnexit);
            Controls.Add(richText_message);
            Controls.Add(btnStart);
            Controls.Add(txtCamState);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbyolo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbefore).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbafter).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private RichTextBox richText_message;
        private Button btnCameraConnect;
        private TextBox txtCamState;
        private Button btnexit;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox ptbbefore;
        private PictureEvent ptbafter;
        private PictureBox ptbyolo;
        private Label label1;
        private Button btnCLAHE;
        private Button btnSaveimg;
        private ListBox lbxCam;
        private ComboBox cmbCameraID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbIOnode;
        private ComboBox cmbDRIVERnode;
        private ComboBox cmb04PInode;
        private ComboBox CmbCardNo;
        private TextBox txtslavenum;
        private TextBox txtcardnum;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtERR;
        private TextBox txtspeed;
        private TextBox txtcommand;
        private Label lbworking;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private TextBox cboDIST;
        private TextBox txtMaxVel;
        private Label label12;
        private Label label11;
        private Button bntResetPos;
        private Button btnStop;
        private Button btnRepeat;
        private Button btnNmove;
        private Button btnPmove;
        private Button btnAllStop;
        private System.Windows.Forms.Timer timer_Inspect;
        private System.Windows.Forms.Timer timer4PI;
        private System.Windows.Forms.Timer timer_repeat;
        private Button btnBI;
        private Button btnFilter;
        private Button btnABI;
        private Button btnAHE;
    }
}