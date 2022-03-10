namespace LightsControlSystemFiveLED
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.gpb_portControl = new System.Windows.Forms.GroupBox();
            this.cbx_portCOMBox = new System.Windows.Forms.ComboBox();
            this.btn_portConnect = new System.Windows.Forms.Button();
            this.pic_OFF_LED1 = new System.Windows.Forms.PictureBox();
            this.pic_ON_LED1 = new System.Windows.Forms.PictureBox();
            this.pic_OFF_LED2 = new System.Windows.Forms.PictureBox();
            this.pic_ON_LED2 = new System.Windows.Forms.PictureBox();
            this.pic_OFF_LED3 = new System.Windows.Forms.PictureBox();
            this.pic_ON_LED3 = new System.Windows.Forms.PictureBox();
            this.pic_OFF_LED4 = new System.Windows.Forms.PictureBox();
            this.pic_ON_LED4 = new System.Windows.Forms.PictureBox();
            this.pic_OFF_LED5 = new System.Windows.Forms.PictureBox();
            this.pic_ON_LED5 = new System.Windows.Forms.PictureBox();
            this.pic_OFF_allLED = new System.Windows.Forms.PictureBox();
            this.pic_ON_allLED = new System.Windows.Forms.PictureBox();
            this.lbl_allLED = new System.Windows.Forms.Label();
            this.lbl_LED1 = new System.Windows.Forms.Label();
            this.lbl_LED2 = new System.Windows.Forms.Label();
            this.lbl_LED3 = new System.Windows.Forms.Label();
            this.lbl_LED4 = new System.Windows.Forms.Label();
            this.lbl_LED5 = new System.Windows.Forms.Label();
            this.grpBox_switchLED1 = new System.Windows.Forms.GroupBox();
            this.btn_ON_LED1 = new System.Windows.Forms.Button();
            this.btn_OFF_LED1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ON_LED2 = new System.Windows.Forms.Button();
            this.btn_OFF_LED2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ON_LED4 = new System.Windows.Forms.Button();
            this.btn_OFF_LED4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ON_LED3 = new System.Windows.Forms.Button();
            this.btn_OFF_LED3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ON_allLED = new System.Windows.Forms.Button();
            this.btn_OFF_allLED = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_ON_LED5 = new System.Windows.Forms.Button();
            this.btn_OFF_LED5 = new System.Windows.Forms.Button();
            this.gpb_portControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_allLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_allLED)).BeginInit();
            this.grpBox_switchLED1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(58, 28);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(480, 47);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "LIGHTING CONTROL SYSTEM";
            // 
            // gpb_portControl
            // 
            this.gpb_portControl.Controls.Add(this.cbx_portCOMBox);
            this.gpb_portControl.Controls.Add(this.btn_portConnect);
            this.gpb_portControl.Location = new System.Drawing.Point(598, 20);
            this.gpb_portControl.Name = "gpb_portControl";
            this.gpb_portControl.Size = new System.Drawing.Size(253, 55);
            this.gpb_portControl.TabIndex = 1;
            this.gpb_portControl.TabStop = false;
            this.gpb_portControl.Text = "Serial Port Selection";
            // 
            // cbx_portCOMBox
            // 
            this.cbx_portCOMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_portCOMBox.FormattingEnabled = true;
            this.cbx_portCOMBox.Location = new System.Drawing.Point(141, 21);
            this.cbx_portCOMBox.Name = "cbx_portCOMBox";
            this.cbx_portCOMBox.Size = new System.Drawing.Size(89, 21);
            this.cbx_portCOMBox.TabIndex = 1;
            // 
            // btn_portConnect
            // 
            this.btn_portConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_portConnect.Location = new System.Drawing.Point(37, 19);
            this.btn_portConnect.Name = "btn_portConnect";
            this.btn_portConnect.Size = new System.Drawing.Size(75, 23);
            this.btn_portConnect.TabIndex = 0;
            this.btn_portConnect.Text = "Connect";
            this.btn_portConnect.UseVisualStyleBackColor = true;
            this.btn_portConnect.Click += new System.EventHandler(this.btn_portConnect_Click);
            // 
            // pic_OFF_LED1
            // 
            this.pic_OFF_LED1.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_LED1.Location = new System.Drawing.Point(49, 90);
            this.pic_OFF_LED1.Name = "pic_OFF_LED1";
            this.pic_OFF_LED1.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_LED1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_LED1.TabIndex = 3;
            this.pic_OFF_LED1.TabStop = false;
            // 
            // pic_ON_LED1
            // 
            this.pic_ON_LED1.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_LED1.Location = new System.Drawing.Point(49, 90);
            this.pic_ON_LED1.Name = "pic_ON_LED1";
            this.pic_ON_LED1.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_LED1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_LED1.TabIndex = 2;
            this.pic_ON_LED1.TabStop = false;
            // 
            // pic_OFF_LED2
            // 
            this.pic_OFF_LED2.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_LED2.Location = new System.Drawing.Point(245, 90);
            this.pic_OFF_LED2.Name = "pic_OFF_LED2";
            this.pic_OFF_LED2.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_LED2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_LED2.TabIndex = 5;
            this.pic_OFF_LED2.TabStop = false;
            // 
            // pic_ON_LED2
            // 
            this.pic_ON_LED2.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_LED2.Location = new System.Drawing.Point(245, 90);
            this.pic_ON_LED2.Name = "pic_ON_LED2";
            this.pic_ON_LED2.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_LED2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_LED2.TabIndex = 4;
            this.pic_ON_LED2.TabStop = false;
            // 
            // pic_OFF_LED3
            // 
            this.pic_OFF_LED3.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_LED3.Location = new System.Drawing.Point(451, 90);
            this.pic_OFF_LED3.Name = "pic_OFF_LED3";
            this.pic_OFF_LED3.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_LED3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_LED3.TabIndex = 7;
            this.pic_OFF_LED3.TabStop = false;
            // 
            // pic_ON_LED3
            // 
            this.pic_ON_LED3.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_LED3.Location = new System.Drawing.Point(451, 90);
            this.pic_ON_LED3.Name = "pic_ON_LED3";
            this.pic_ON_LED3.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_LED3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_LED3.TabIndex = 6;
            this.pic_ON_LED3.TabStop = false;
            // 
            // pic_OFF_LED4
            // 
            this.pic_OFF_LED4.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_LED4.Location = new System.Drawing.Point(649, 90);
            this.pic_OFF_LED4.Name = "pic_OFF_LED4";
            this.pic_OFF_LED4.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_LED4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_LED4.TabIndex = 9;
            this.pic_OFF_LED4.TabStop = false;
            // 
            // pic_ON_LED4
            // 
            this.pic_ON_LED4.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_LED4.Location = new System.Drawing.Point(649, 90);
            this.pic_ON_LED4.Name = "pic_ON_LED4";
            this.pic_ON_LED4.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_LED4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_LED4.TabIndex = 8;
            this.pic_ON_LED4.TabStop = false;
            // 
            // pic_OFF_LED5
            // 
            this.pic_OFF_LED5.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_LED5.Location = new System.Drawing.Point(860, 90);
            this.pic_OFF_LED5.Name = "pic_OFF_LED5";
            this.pic_OFF_LED5.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_LED5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_LED5.TabIndex = 11;
            this.pic_OFF_LED5.TabStop = false;
            // 
            // pic_ON_LED5
            // 
            this.pic_ON_LED5.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_LED5.Location = new System.Drawing.Point(860, 90);
            this.pic_ON_LED5.Name = "pic_ON_LED5";
            this.pic_ON_LED5.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_LED5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_LED5.TabIndex = 10;
            this.pic_ON_LED5.TabStop = false;
            // 
            // pic_OFF_allLED
            // 
            this.pic_OFF_allLED.Image = global::LightsControlSystemFiveLED.Properties.Resources.off;
            this.pic_OFF_allLED.Location = new System.Drawing.Point(1056, 90);
            this.pic_OFF_allLED.Name = "pic_OFF_allLED";
            this.pic_OFF_allLED.Size = new System.Drawing.Size(100, 89);
            this.pic_OFF_allLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_OFF_allLED.TabIndex = 13;
            this.pic_OFF_allLED.TabStop = false;
            // 
            // pic_ON_allLED
            // 
            this.pic_ON_allLED.Image = global::LightsControlSystemFiveLED.Properties.Resources.on;
            this.pic_ON_allLED.Location = new System.Drawing.Point(1056, 90);
            this.pic_ON_allLED.Name = "pic_ON_allLED";
            this.pic_ON_allLED.Size = new System.Drawing.Size(100, 89);
            this.pic_ON_allLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ON_allLED.TabIndex = 12;
            this.pic_ON_allLED.TabStop = false;
            // 
            // lbl_allLED
            // 
            this.lbl_allLED.AutoSize = true;
            this.lbl_allLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allLED.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_allLED.Location = new System.Drawing.Point(1068, 186);
            this.lbl_allLED.Name = "lbl_allLED";
            this.lbl_allLED.Size = new System.Drawing.Size(73, 18);
            this.lbl_allLED.TabIndex = 14;
            this.lbl_allLED.Text = "ALL LED";
            // 
            // lbl_LED1
            // 
            this.lbl_LED1.AutoSize = true;
            this.lbl_LED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LED1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LED1.Location = new System.Drawing.Point(71, 186);
            this.lbl_LED1.Name = "lbl_LED1";
            this.lbl_LED1.Size = new System.Drawing.Size(54, 18);
            this.lbl_LED1.TabIndex = 15;
            this.lbl_LED1.Text = "LED 1";
            // 
            // lbl_LED2
            // 
            this.lbl_LED2.AutoSize = true;
            this.lbl_LED2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LED2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LED2.Location = new System.Drawing.Point(267, 186);
            this.lbl_LED2.Name = "lbl_LED2";
            this.lbl_LED2.Size = new System.Drawing.Size(54, 18);
            this.lbl_LED2.TabIndex = 16;
            this.lbl_LED2.Text = "LED 2";
            // 
            // lbl_LED3
            // 
            this.lbl_LED3.AutoSize = true;
            this.lbl_LED3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LED3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LED3.Location = new System.Drawing.Point(473, 186);
            this.lbl_LED3.Name = "lbl_LED3";
            this.lbl_LED3.Size = new System.Drawing.Size(54, 18);
            this.lbl_LED3.TabIndex = 17;
            this.lbl_LED3.Text = "LED 3";
            // 
            // lbl_LED4
            // 
            this.lbl_LED4.AutoSize = true;
            this.lbl_LED4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LED4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LED4.Location = new System.Drawing.Point(672, 186);
            this.lbl_LED4.Name = "lbl_LED4";
            this.lbl_LED4.Size = new System.Drawing.Size(54, 18);
            this.lbl_LED4.TabIndex = 18;
            this.lbl_LED4.Text = "LED 4";
            // 
            // lbl_LED5
            // 
            this.lbl_LED5.AutoSize = true;
            this.lbl_LED5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LED5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LED5.Location = new System.Drawing.Point(881, 186);
            this.lbl_LED5.Name = "lbl_LED5";
            this.lbl_LED5.Size = new System.Drawing.Size(54, 18);
            this.lbl_LED5.TabIndex = 19;
            this.lbl_LED5.Text = "LED 5";
            // 
            // grpBox_switchLED1
            // 
            this.grpBox_switchLED1.Controls.Add(this.btn_ON_LED1);
            this.grpBox_switchLED1.Controls.Add(this.btn_OFF_LED1);
            this.grpBox_switchLED1.Location = new System.Drawing.Point(12, 212);
            this.grpBox_switchLED1.Name = "grpBox_switchLED1";
            this.grpBox_switchLED1.Size = new System.Drawing.Size(172, 59);
            this.grpBox_switchLED1.TabIndex = 20;
            this.grpBox_switchLED1.TabStop = false;
            this.grpBox_switchLED1.Text = "Switch";
            // 
            // btn_ON_LED1
            // 
            this.btn_ON_LED1.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_LED1.Location = new System.Drawing.Point(18, 19);
            this.btn_ON_LED1.Name = "btn_ON_LED1";
            this.btn_ON_LED1.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_LED1.TabIndex = 2;
            this.btn_ON_LED1.Text = "ON";
            this.btn_ON_LED1.UseVisualStyleBackColor = true;
            this.btn_ON_LED1.Click += new System.EventHandler(this.btn_ON_LED1_Click);
            // 
            // btn_OFF_LED1
            // 
            this.btn_OFF_LED1.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_LED1.Location = new System.Drawing.Point(95, 19);
            this.btn_OFF_LED1.Name = "btn_OFF_LED1";
            this.btn_OFF_LED1.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_LED1.TabIndex = 1;
            this.btn_OFF_LED1.Text = "OFF";
            this.btn_OFF_LED1.UseVisualStyleBackColor = true;
            this.btn_OFF_LED1.Click += new System.EventHandler(this.btn_OFF_LED1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ON_LED2);
            this.groupBox1.Controls.Add(this.btn_OFF_LED2);
            this.groupBox1.Location = new System.Drawing.Point(213, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 59);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch";
            // 
            // btn_ON_LED2
            // 
            this.btn_ON_LED2.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_LED2.Location = new System.Drawing.Point(20, 19);
            this.btn_ON_LED2.Name = "btn_ON_LED2";
            this.btn_ON_LED2.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_LED2.TabIndex = 2;
            this.btn_ON_LED2.Text = "ON";
            this.btn_ON_LED2.UseVisualStyleBackColor = true;
            this.btn_ON_LED2.Click += new System.EventHandler(this.btn_ON_LED2_Click);
            // 
            // btn_OFF_LED2
            // 
            this.btn_OFF_LED2.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_LED2.Location = new System.Drawing.Point(96, 19);
            this.btn_OFF_LED2.Name = "btn_OFF_LED2";
            this.btn_OFF_LED2.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_LED2.TabIndex = 1;
            this.btn_OFF_LED2.Text = "OFF";
            this.btn_OFF_LED2.UseVisualStyleBackColor = true;
            this.btn_OFF_LED2.Click += new System.EventHandler(this.btn_OFF_LED2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ON_LED4);
            this.groupBox2.Controls.Add(this.btn_OFF_LED4);
            this.groupBox2.Location = new System.Drawing.Point(613, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 59);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch";
            // 
            // btn_ON_LED4
            // 
            this.btn_ON_LED4.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_LED4.Location = new System.Drawing.Point(20, 19);
            this.btn_ON_LED4.Name = "btn_ON_LED4";
            this.btn_ON_LED4.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_LED4.TabIndex = 2;
            this.btn_ON_LED4.Text = "ON";
            this.btn_ON_LED4.UseVisualStyleBackColor = true;
            this.btn_ON_LED4.Click += new System.EventHandler(this.btn_ON_LED4_Click);
            // 
            // btn_OFF_LED4
            // 
            this.btn_OFF_LED4.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_LED4.Location = new System.Drawing.Point(96, 19);
            this.btn_OFF_LED4.Name = "btn_OFF_LED4";
            this.btn_OFF_LED4.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_LED4.TabIndex = 1;
            this.btn_OFF_LED4.Text = "OFF";
            this.btn_OFF_LED4.UseVisualStyleBackColor = true;
            this.btn_OFF_LED4.Click += new System.EventHandler(this.btn_OFF_LED4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ON_LED3);
            this.groupBox3.Controls.Add(this.btn_OFF_LED3);
            this.groupBox3.Location = new System.Drawing.Point(412, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 59);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Switch";
            // 
            // btn_ON_LED3
            // 
            this.btn_ON_LED3.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_LED3.Location = new System.Drawing.Point(18, 19);
            this.btn_ON_LED3.Name = "btn_ON_LED3";
            this.btn_ON_LED3.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_LED3.TabIndex = 2;
            this.btn_ON_LED3.Text = "ON";
            this.btn_ON_LED3.UseVisualStyleBackColor = true;
            this.btn_ON_LED3.Click += new System.EventHandler(this.btn_ON_LED3_Click);
            // 
            // btn_OFF_LED3
            // 
            this.btn_OFF_LED3.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_LED3.Location = new System.Drawing.Point(95, 19);
            this.btn_OFF_LED3.Name = "btn_OFF_LED3";
            this.btn_OFF_LED3.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_LED3.TabIndex = 1;
            this.btn_OFF_LED3.Text = "OFF";
            this.btn_OFF_LED3.UseVisualStyleBackColor = true;
            this.btn_OFF_LED3.Click += new System.EventHandler(this.btn_OFF_LED3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ON_allLED);
            this.groupBox4.Controls.Add(this.btn_OFF_allLED);
            this.groupBox4.Location = new System.Drawing.Point(1020, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 59);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Switch";
            // 
            // btn_ON_allLED
            // 
            this.btn_ON_allLED.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_allLED.Location = new System.Drawing.Point(20, 19);
            this.btn_ON_allLED.Name = "btn_ON_allLED";
            this.btn_ON_allLED.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_allLED.TabIndex = 2;
            this.btn_ON_allLED.Text = "ON";
            this.btn_ON_allLED.UseVisualStyleBackColor = true;
            this.btn_ON_allLED.Click += new System.EventHandler(this.btn_ON_allLED_Click);
            // 
            // btn_OFF_allLED
            // 
            this.btn_OFF_allLED.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_allLED.Location = new System.Drawing.Point(96, 19);
            this.btn_OFF_allLED.Name = "btn_OFF_allLED";
            this.btn_OFF_allLED.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_allLED.TabIndex = 1;
            this.btn_OFF_allLED.Text = "OFF";
            this.btn_OFF_allLED.UseVisualStyleBackColor = true;
            this.btn_OFF_allLED.Click += new System.EventHandler(this.btn_OFF_allLED_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_ON_LED5);
            this.groupBox5.Controls.Add(this.btn_OFF_LED5);
            this.groupBox5.Location = new System.Drawing.Point(819, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 59);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Switch";
            // 
            // btn_ON_LED5
            // 
            this.btn_ON_LED5.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ON_LED5.Location = new System.Drawing.Point(18, 19);
            this.btn_ON_LED5.Name = "btn_ON_LED5";
            this.btn_ON_LED5.Size = new System.Drawing.Size(59, 31);
            this.btn_ON_LED5.TabIndex = 2;
            this.btn_ON_LED5.Text = "ON";
            this.btn_ON_LED5.UseVisualStyleBackColor = true;
            this.btn_ON_LED5.Click += new System.EventHandler(this.btn_ON_LED5_Click);
            // 
            // btn_OFF_LED5
            // 
            this.btn_OFF_LED5.ForeColor = System.Drawing.Color.Red;
            this.btn_OFF_LED5.Location = new System.Drawing.Point(95, 19);
            this.btn_OFF_LED5.Name = "btn_OFF_LED5";
            this.btn_OFF_LED5.Size = new System.Drawing.Size(59, 31);
            this.btn_OFF_LED5.TabIndex = 1;
            this.btn_OFF_LED5.Text = "OFF";
            this.btn_OFF_LED5.UseVisualStyleBackColor = true;
            this.btn_OFF_LED5.Click += new System.EventHandler(this.btn_OFF_LED5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 564);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_LED1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_switchLED1);
            this.Controls.Add(this.lbl_LED5);
            this.Controls.Add(this.lbl_LED4);
            this.Controls.Add(this.lbl_LED3);
            this.Controls.Add(this.lbl_LED2);
            this.Controls.Add(this.lbl_allLED);
            this.Controls.Add(this.gpb_portControl);
            this.Controls.Add(this.pic_OFF_LED1);
            this.Controls.Add(this.pic_ON_LED1);
            this.Controls.Add(this.pic_OFF_LED2);
            this.Controls.Add(this.pic_ON_LED2);
            this.Controls.Add(this.pic_OFF_LED3);
            this.Controls.Add(this.pic_OFF_LED4);
            this.Controls.Add(this.pic_ON_LED3);
            this.Controls.Add(this.pic_ON_LED4);
            this.Controls.Add(this.pic_OFF_LED5);
            this.Controls.Add(this.pic_ON_LED5);
            this.Controls.Add(this.pic_OFF_allLED);
            this.Controls.Add(this.pic_ON_allLED);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lighting Control System";
            this.gpb_portControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_LED5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_LED5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OFF_allLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ON_allLED)).EndInit();
            this.grpBox_switchLED1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gpb_portControl;
        private System.Windows.Forms.ComboBox cbx_portCOMBox;
        private System.Windows.Forms.Button btn_portConnect;
        private System.Windows.Forms.PictureBox pic_ON_LED1;
        private System.Windows.Forms.PictureBox pic_OFF_LED1;
        private System.Windows.Forms.PictureBox pic_OFF_LED2;
        private System.Windows.Forms.PictureBox pic_ON_LED2;
        private System.Windows.Forms.PictureBox pic_OFF_LED3;
        private System.Windows.Forms.PictureBox pic_ON_LED3;
        private System.Windows.Forms.PictureBox pic_OFF_LED4;
        private System.Windows.Forms.PictureBox pic_ON_LED4;
        private System.Windows.Forms.PictureBox pic_OFF_LED5;
        private System.Windows.Forms.PictureBox pic_ON_LED5;
        private System.Windows.Forms.PictureBox pic_OFF_allLED;
        private System.Windows.Forms.PictureBox pic_ON_allLED;
        private System.Windows.Forms.Label lbl_allLED;
        private System.Windows.Forms.Label lbl_LED1;
        private System.Windows.Forms.Label lbl_LED2;
        private System.Windows.Forms.Label lbl_LED3;
        private System.Windows.Forms.Label lbl_LED4;
        private System.Windows.Forms.Label lbl_LED5;
        private System.Windows.Forms.GroupBox grpBox_switchLED1;
        private System.Windows.Forms.Button btn_ON_LED1;
        private System.Windows.Forms.Button btn_OFF_LED1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ON_LED2;
        private System.Windows.Forms.Button btn_OFF_LED2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ON_LED4;
        private System.Windows.Forms.Button btn_OFF_LED4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ON_LED3;
        private System.Windows.Forms.Button btn_OFF_LED3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ON_allLED;
        private System.Windows.Forms.Button btn_OFF_allLED;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_ON_LED5;
        private System.Windows.Forms.Button btn_OFF_LED5;
    }
}

