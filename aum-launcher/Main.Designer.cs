
namespace aum_launcher
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.Menu_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxProcessIcon = new System.Windows.Forms.PictureBox();
            this.lblProcessDetails = new System.Windows.Forms.Label();
            this.lblGameDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSwitchToInjectable = new System.Windows.Forms.Button();
            this.btnSwitchToProxy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLauncherVersion = new System.Windows.Forms.Label();
            this.StatusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.StatusLbl_Launcher = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLbl_AUM = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLbl_Game = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLbl_Injection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnToggleLogDisplay = new System.Windows.Forms.Button();
            this.ToolTip_Main = new System.Windows.Forms.ToolTip(this.components);
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_MenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(465, 24);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // Menu_MenuItem
            // 
            this.Menu_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout_MenuItem});
            this.Menu_MenuItem.Name = "Menu_MenuItem";
            this.Menu_MenuItem.Size = new System.Drawing.Size(50, 20);
            this.Menu_MenuItem.Text = "Menu";
            // 
            // MenuAbout_MenuItem
            // 
            this.MenuAbout_MenuItem.Name = "MenuAbout_MenuItem";
            this.MenuAbout_MenuItem.Size = new System.Drawing.Size(107, 22);
            this.MenuAbout_MenuItem.Text = "About";
            this.MenuAbout_MenuItem.Click += new System.EventHandler(this.MenuAbout_MenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "About";
            // 
            // pictureBoxProcessIcon
            // 
            this.pictureBoxProcessIcon.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxProcessIcon.Name = "pictureBoxProcessIcon";
            this.pictureBoxProcessIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxProcessIcon.TabIndex = 1;
            this.pictureBoxProcessIcon.TabStop = false;
            // 
            // lblProcessDetails
            // 
            this.lblProcessDetails.AutoSize = true;
            this.lblProcessDetails.Location = new System.Drawing.Point(50, 27);
            this.lblProcessDetails.Name = "lblProcessDetails";
            this.lblProcessDetails.Size = new System.Drawing.Size(186, 15);
            this.lblProcessDetails.TabIndex = 2;
            this.lblProcessDetails.Text = "Process: AmongUs.exe (PID: 4096)";
            // 
            // lblGameDetails
            // 
            this.lblGameDetails.AutoSize = true;
            this.lblGameDetails.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGameDetails.Location = new System.Drawing.Point(50, 44);
            this.lblGameDetails.Name = "lblGameDetails";
            this.lblGameDetails.Size = new System.Drawing.Size(298, 15);
            this.lblGameDetails.TabIndex = 3;
            this.lblGameDetails.Text = "Game Checksum: laksdjfoiawehfoaiwehgt4 (match OK)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnSwitchToInjectable);
            this.groupBox1.Controls.Add(this.btnSwitchToProxy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblLauncherVersion);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aum_launcher.Properties.Resources.org_logo;
            this.pictureBox1.Location = new System.Drawing.Point(355, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.ToolTip_Main.SetToolTip(this.pictureBox1, "AUM is made free and open-source by BitCrackers\r\nhttps://github.com/BitCrackers");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(112, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Use debug build";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSwitchToInjectable
            // 
            this.btnSwitchToInjectable.Location = new System.Drawing.Point(134, 95);
            this.btnSwitchToInjectable.Name = "btnSwitchToInjectable";
            this.btnSwitchToInjectable.Size = new System.Drawing.Size(122, 23);
            this.btnSwitchToInjectable.TabIndex = 6;
            this.btnSwitchToInjectable.Text = "Switch to Injectable";
            this.btnSwitchToInjectable.UseVisualStyleBackColor = true;
            // 
            // btnSwitchToProxy
            // 
            this.btnSwitchToProxy.Enabled = false;
            this.btnSwitchToProxy.Location = new System.Drawing.Point(6, 95);
            this.btnSwitchToProxy.Name = "btnSwitchToProxy";
            this.btnSwitchToProxy.Size = new System.Drawing.Size(122, 23);
            this.btnSwitchToProxy.TabIndex = 5;
            this.btnSwitchToProxy.Text = "Switch to Proxy";
            this.btnSwitchToProxy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currently using: (Release Proxy)";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(360, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblLauncherVersion
            // 
            this.lblLauncherVersion.AutoSize = true;
            this.lblLauncherVersion.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLauncherVersion.Location = new System.Drawing.Point(6, 19);
            this.lblLauncherVersion.Name = "lblLauncherVersion";
            this.lblLauncherVersion.Size = new System.Drawing.Size(331, 15);
            this.lblLauncherVersion.TabIndex = 0;
            this.lblLauncherVersion.Text = "Launcher Checksum: lkajsdfoasdfawetaaeiawet81 (match OK)";
            // 
            // StatusStrip_Main
            // 
            this.StatusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbl_Launcher,
            this.StatusLbl_AUM,
            this.StatusLbl_Game,
            this.StatusLbl_Injection});
            this.StatusStrip_Main.Location = new System.Drawing.Point(0, 411);
            this.StatusStrip_Main.Name = "StatusStrip_Main";
            this.StatusStrip_Main.Size = new System.Drawing.Size(465, 22);
            this.StatusStrip_Main.SizingGrip = false;
            this.StatusStrip_Main.TabIndex = 5;
            this.StatusStrip_Main.Text = "statusStrip1";
            // 
            // StatusLbl_Launcher
            // 
            this.StatusLbl_Launcher.ForeColor = System.Drawing.Color.LimeGreen;
            this.StatusLbl_Launcher.Name = "StatusLbl_Launcher";
            this.StatusLbl_Launcher.Size = new System.Drawing.Size(78, 17);
            this.StatusLbl_Launcher.Text = "Launcher: OK";
            // 
            // StatusLbl_AUM
            // 
            this.StatusLbl_AUM.ForeColor = System.Drawing.Color.Red;
            this.StatusLbl_AUM.Name = "StatusLbl_AUM";
            this.StatusLbl_AUM.Size = new System.Drawing.Size(77, 17);
            this.StatusLbl_AUM.Text = "AUM: update";
            // 
            // StatusLbl_Game
            // 
            this.StatusLbl_Game.ForeColor = System.Drawing.Color.LimeGreen;
            this.StatusLbl_Game.Name = "StatusLbl_Game";
            this.StatusLbl_Game.Size = new System.Drawing.Size(60, 17);
            this.StatusLbl_Game.Text = "Game: OK";
            // 
            // StatusLbl_Injection
            // 
            this.StatusLbl_Injection.ForeColor = System.Drawing.Color.DarkOrange;
            this.StatusLbl_Injection.Name = "StatusLbl_Injection";
            this.StatusLbl_Injection.Size = new System.Drawing.Size(107, 17);
            this.StatusLbl_Injection.Text = "Injection: waiting...";
            // 
            // btnToggleLogDisplay
            // 
            this.btnToggleLogDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleLogDisplay.Location = new System.Drawing.Point(201, 233);
            this.btnToggleLogDisplay.Name = "btnToggleLogDisplay";
            this.btnToggleLogDisplay.Size = new System.Drawing.Size(54, 23);
            this.btnToggleLogDisplay.TabIndex = 6;
            this.btnToggleLogDisplay.Text = "↕ ↕ ↕";
            this.btnToggleLogDisplay.UseVisualStyleBackColor = true;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(12, 262);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(441, 146);
            this.rtxtLog.TabIndex = 7;
            this.rtxtLog.Text = resources.GetString("rtxtLog.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "AUM Version:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 433);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.btnToggleLogDisplay);
            this.Controls.Add(this.StatusStrip_Main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGameDetails);
            this.Controls.Add(this.lblProcessDetails);
            this.Controls.Add(this.pictureBoxProcessIcon);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "AmongUsMenu Launcher";
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusStrip_Main.ResumeLayout(false);
            this.StatusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem Menu_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout_MenuItem;
        private System.Windows.Forms.PictureBox pictureBoxProcessIcon;
        private System.Windows.Forms.Label lblProcessDetails;
        private System.Windows.Forms.Label lblGameDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSwitchToInjectable;
        private System.Windows.Forms.Button btnSwitchToProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLauncherVersion;
        private System.Windows.Forms.StatusStrip StatusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl_Launcher;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl_AUM;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl_Game;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl_Injection;
        private System.Windows.Forms.Button btnToggleLogDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ToolTip_Main;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

