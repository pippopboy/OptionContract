namespace Hosting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbaseaddress = new System.Windows.Forms.TextBox();
            this.cbMex = new System.Windows.Forms.CheckBox();
            this.btStartService = new System.Windows.Forms.Button();
            this.cbBinding = new System.Windows.Forms.ComboBox();
            this.lbmessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStopService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txLocation = new System.Windows.Forms.TextBox();
            this.btSaveConfig = new System.Windows.Forms.Button();
            this.txtServiceContract2 = new System.Windows.Forms.TextBox();
            this.txtServiceContract1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbServiceContract1 = new System.Windows.Forms.CheckBox();
            this.cbServiceContract2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Location";
            // 
            // txbaseaddress
            // 
            this.txbaseaddress.Location = new System.Drawing.Point(115, 40);
            this.txbaseaddress.Name = "txbaseaddress";
            this.txbaseaddress.Size = new System.Drawing.Size(213, 20);
            this.txbaseaddress.TabIndex = 1;
            // 
            // cbMex
            // 
            this.cbMex.AutoSize = true;
            this.cbMex.Location = new System.Drawing.Point(115, 85);
            this.cbMex.Name = "cbMex";
            this.cbMex.Size = new System.Drawing.Size(15, 14);
            this.cbMex.TabIndex = 2;
            this.cbMex.UseVisualStyleBackColor = true;
            // 
            // btStartService
            // 
            this.btStartService.Location = new System.Drawing.Point(159, 75);
            this.btStartService.Name = "btStartService";
            this.btStartService.Size = new System.Drawing.Size(75, 23);
            this.btStartService.TabIndex = 3;
            this.btStartService.Text = "Start";
            this.btStartService.UseVisualStyleBackColor = true;
            this.btStartService.Click += new System.EventHandler(this.BtStartServiceClick);
            // 
            // cbBinding
            // 
            this.cbBinding.DisplayMember = "Binding";
            this.cbBinding.FormattingEnabled = true;
            this.cbBinding.Items.AddRange(new object[] {
            "HttpBasicBinding",
            "WsHttpBinding",
            "NetTcpBinding",
            "WsDualHttpBinding"});
            this.cbBinding.Location = new System.Drawing.Point(89, 20);
            this.cbBinding.Name = "cbBinding";
            this.cbBinding.Size = new System.Drawing.Size(121, 21);
            this.cbBinding.TabIndex = 4;
            // 
            // lbmessage
            // 
            this.lbmessage.AutoSize = true;
            this.lbmessage.Location = new System.Drawing.Point(168, 9);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(0, 13);
            this.lbmessage.TabIndex = 5;
            this.lbmessage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show Mex";
            // 
            // btStopService
            // 
            this.btStopService.Location = new System.Drawing.Point(240, 75);
            this.btStopService.Name = "btStopService";
            this.btStopService.Size = new System.Drawing.Size(75, 23);
            this.btStopService.TabIndex = 7;
            this.btStopService.Text = "Stop";
            this.btStopService.UseVisualStyleBackColor = true;
            this.btStopService.Click += new System.EventHandler(this.BtStopServiceClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "EndPoint";
            // 
            // txLocation
            // 
            this.txLocation.Location = new System.Drawing.Point(227, 19);
            this.txLocation.Name = "txLocation";
            this.txLocation.Size = new System.Drawing.Size(142, 20);
            this.txLocation.TabIndex = 9;
            this.txLocation.Text = "Location";
            this.txLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txLocation_MouseClick);
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.Location = new System.Drawing.Point(164, 99);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btSaveConfig.TabIndex = 10;
            this.btSaveConfig.Text = "Save Config";
            this.btSaveConfig.UseVisualStyleBackColor = true;
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click);
            // 
            // txtServiceContract2
            // 
            this.txtServiceContract2.Location = new System.Drawing.Point(89, 73);
            this.txtServiceContract2.Name = "txtServiceContract2";
            this.txtServiceContract2.ReadOnly = true;
            this.txtServiceContract2.Size = new System.Drawing.Size(213, 20);
            this.txtServiceContract2.TabIndex = 11;
            this.txtServiceContract2.Text = "IOption1";
            this.txtServiceContract2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtServiceContract2_MouseClick);
            // 
            // txtServiceContract1
            // 
            this.txtServiceContract1.Location = new System.Drawing.Point(89, 47);
            this.txtServiceContract1.Name = "txtServiceContract1";
            this.txtServiceContract1.ReadOnly = true;
            this.txtServiceContract1.Size = new System.Drawing.Size(213, 20);
            this.txtServiceContract1.TabIndex = 12;
            this.txtServiceContract1.Text = "IOption";
            this.txtServiceContract1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtServiceContract1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbServiceContract1);
            this.groupBox1.Controls.Add(this.cbServiceContract2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSaveConfig);
            this.groupBox1.Controls.Add(this.txtServiceContract2);
            this.groupBox1.Controls.Add(this.txtServiceContract1);
            this.groupBox1.Controls.Add(this.cbBinding);
            this.groupBox1.Controls.Add(this.txLocation);
            this.groupBox1.Location = new System.Drawing.Point(37, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 145);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // cbServiceContract1
            // 
            this.cbServiceContract1.AutoSize = true;
            this.cbServiceContract1.Location = new System.Drawing.Point(48, 53);
            this.cbServiceContract1.Name = "cbServiceContract1";
            this.cbServiceContract1.Size = new System.Drawing.Size(15, 14);
            this.cbServiceContract1.TabIndex = 14;
            this.cbServiceContract1.UseVisualStyleBackColor = true;
            // 
            // cbServiceContract2
            // 
            this.cbServiceContract2.AutoSize = true;
            this.cbServiceContract2.Location = new System.Drawing.Point(48, 79);
            this.cbServiceContract2.Name = "cbServiceContract2";
            this.cbServiceContract2.Size = new System.Drawing.Size(15, 14);
            this.cbServiceContract2.TabIndex = 13;
            this.cbServiceContract2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStopService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.btStartService);
            this.Controls.Add(this.txbaseaddress);
            this.Controls.Add(this.cbMex);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbaseaddress;
        private System.Windows.Forms.CheckBox cbMex;
        private System.Windows.Forms.Button btStartService;
        private System.Windows.Forms.ComboBox cbBinding;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStopService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txLocation;
        private System.Windows.Forms.Button btSaveConfig;
        private System.Windows.Forms.TextBox txtServiceContract2;
        private System.Windows.Forms.TextBox txtServiceContract1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbServiceContract2;
        private System.Windows.Forms.CheckBox cbServiceContract1;
    }
}

