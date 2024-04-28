using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace progetto_scuola
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.BackNickname = new ReaLTaiizor.Controls.CyberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.labelPts = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.hScrollVolume = new ReaLTaiizor.Controls.MaterialScrollBar();
            this.panelSettings = new ReaLTaiizor.Controls.Panel();
            this.panelVolumeInside = new ReaLTaiizor.Controls.Panel();
            this.ScrollVolume = new ReaLTaiizor.Controls.MaterialScrollBar();
            this.panelPerso = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVinto = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDescrNome = new System.Windows.Forms.Label();
            this.lblDescrPts = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelVolumeInside.SuspendLayout();
            this.panelPerso.SuspendLayout();
            this.panelVinto.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTitle.Controls.Add(this.spaceClose1);
            this.panelTitle.Controls.Add(this.bigLabel1);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(2000, 123);
            this.panelTitle.TabIndex = 0;
            // 
            // spaceClose1
            // 
            this.spaceClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            this.spaceClose1.DefaultAnchor = true;
            this.spaceClose1.DefaultLocation = true;
            this.spaceClose1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceClose1.Image = null;
            this.spaceClose1.Location = new System.Drawing.Point(1966, 3);
            this.spaceClose1.Margin = new System.Windows.Forms.Padding(4);
            this.spaceClose1.Name = "spaceClose1";
            this.spaceClose1.NoRounding = false;
            this.spaceClose1.Size = new System.Drawing.Size(31, 26);
            this.spaceClose1.TabIndex = 2;
            this.spaceClose1.Text = "x";
            this.spaceClose1.Transparent = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Cooper Black", 40F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(287, 30);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(656, 77);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Indovina la parola";
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("Cooper Black", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(52, 449);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(433, 160);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Gioca ora";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txtNickname);
            this.panelName.Controls.Add(this.buttonConfirm);
            this.panelName.Controls.Add(this.BackNickname);
            this.panelName.Controls.Add(this.label3);
            this.panelName.Location = new System.Drawing.Point(936, 427);
            this.panelName.Margin = new System.Windows.Forms.Padding(0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(917, 222);
            this.panelName.TabIndex = 16;
            // 
            // txtNickname
            // 
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtNickname.Location = new System.Drawing.Point(83, 78);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(4);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(761, 53);
            this.txtNickname.TabIndex = 18;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.buttonConfirm.Location = new System.Drawing.Point(353, 154);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(243, 58);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Continua";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // BackNickname
            // 
            this.BackNickname.Alpha = 20;
            this.BackNickname.BackColor = System.Drawing.Color.Transparent;
            this.BackNickname.Background_WidthPen = 3F;
            this.BackNickname.BackgroundPen = true;
            this.BackNickname.ColorBackground = System.Drawing.Color.White;
            this.BackNickname.ColorBackground_Pen = System.Drawing.Color.DeepSkyBlue;
            this.BackNickname.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.BackNickname.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.BackNickname.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BackNickname.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BackNickname.Enabled = false;
            this.BackNickname.Font = new System.Drawing.Font("Arial", 18F);
            this.BackNickname.ForeColor = System.Drawing.Color.Black;
            this.BackNickname.Lighting = false;
            this.BackNickname.LinearGradientPen = false;
            this.BackNickname.Location = new System.Drawing.Point(63, 66);
            this.BackNickname.Margin = new System.Windows.Forms.Padding(4);
            this.BackNickname.Name = "BackNickname";
            this.BackNickname.PenWidth = 15;
            this.BackNickname.RGB = false;
            this.BackNickname.Rounding = true;
            this.BackNickname.RoundingInt = 60;
            this.BackNickname.Size = new System.Drawing.Size(800, 74);
            this.BackNickname.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BackNickname.TabIndex = 3;
            this.BackNickname.Tag = "Cyber";
            this.BackNickname.TextButton = "";
            this.BackNickname.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackNickname.Timer_RGB = 300;
            this.BackNickname.TextChanged += new ReaLTaiizor.Controls.CyberTextBox.EventHandler(this.txtNickname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inserisci il tuo nickname";
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuess.Font = new System.Drawing.Font("Cooper Black", 40F);
            this.btnGuess.Location = new System.Drawing.Point(772, 362);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(381, 124);
            this.btnGuess.TabIndex = 18;
            this.btnGuess.Text = "Tenta";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Visible = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // labelPts
            // 
            this.labelPts.AutoSize = true;
            this.labelPts.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPts.Location = new System.Drawing.Point(157, 39);
            this.labelPts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPts.Name = "labelPts";
            this.labelPts.Size = new System.Drawing.Size(141, 29);
            this.labelPts.TabIndex = 20;
            this.labelPts.Text = "Punteggio";
            this.labelPts.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelNome.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(151, 11);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(462, 31);
            this.labelNome.TabIndex = 19;
            this.labelNome.Text = "WWWWWWWWWWWWWWWW";
            this.labelNome.Visible = false;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(126, 36);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(51, 16);
            this.labelVolume.TabIndex = 25;
            this.labelVolume.Text = "volume";
            // 
            // hScrollVolume
            // 
            this.hScrollVolume.Depth = 0;
            this.hScrollVolume.Location = new System.Drawing.Point(0, 0);
            this.hScrollVolume.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.hScrollVolume.Name = "hScrollVolume";
            this.hScrollVolume.Orientation = ReaLTaiizor.Enum.Material.MateScrollOrientation.Vertical;
            this.hScrollVolume.Size = new System.Drawing.Size(10, 200);
            this.hScrollVolume.TabIndex = 0;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSettings.Controls.Add(this.panelVolumeInside);
            this.panelSettings.Controls.Add(this.labelVolume);
            this.panelSettings.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelSettings.Location = new System.Drawing.Point(1275, 144);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelSettings.Size = new System.Drawing.Size(298, 137);
            this.panelSettings.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelSettings.TabIndex = 27;
            this.panelSettings.Text = "panel2";
            this.panelSettings.Visible = false;
            // 
            // panelVolumeInside
            // 
            this.panelVolumeInside.BackColor = System.Drawing.Color.White;
            this.panelVolumeInside.Controls.Add(this.ScrollVolume);
            this.panelVolumeInside.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelVolumeInside.Location = new System.Drawing.Point(15, 56);
            this.panelVolumeInside.Margin = new System.Windows.Forms.Padding(4);
            this.panelVolumeInside.Name = "panelVolumeInside";
            this.panelVolumeInside.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelVolumeInside.Size = new System.Drawing.Size(267, 12);
            this.panelVolumeInside.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelVolumeInside.TabIndex = 35;
            // 
            // ScrollVolume
            // 
            this.ScrollVolume.Depth = 0;
            this.ScrollVolume.Location = new System.Drawing.Point(0, 0);
            this.ScrollVolume.Margin = new System.Windows.Forms.Padding(4);
            this.ScrollVolume.Maximum = 109;
            this.ScrollVolume.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.ScrollVolume.Name = "ScrollVolume";
            this.ScrollVolume.Orientation = ReaLTaiizor.Enum.Material.MateScrollOrientation.Horizontal;
            this.ScrollVolume.ScrollbarSize = 12;
            this.ScrollVolume.Size = new System.Drawing.Size(267, 12);
            this.ScrollVolume.TabIndex = 36;
            this.ScrollVolume.Text = "materialScrollBar1";
            this.ScrollVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollVolume_Scroll);
            // 
            // panelPerso
            // 
            this.panelPerso.BackColor = System.Drawing.Color.White;
            this.panelPerso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerso.Controls.Add(this.panel3);
            this.panelPerso.Controls.Add(this.label4);
            this.panelPerso.Location = new System.Drawing.Point(1120, 689);
            this.panelPerso.Margin = new System.Windows.Forms.Padding(4);
            this.panelPerso.Name = "panelPerso";
            this.panelPerso.Size = new System.Drawing.Size(798, 260);
            this.panelPerso.TabIndex = 29;
            this.panelPerso.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(536, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 158);
            this.panel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 50F);
            this.label4.Location = new System.Drawing.Point(55, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 96);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hai perso";
            // 
            // panelVinto
            // 
            this.panelVinto.BackColor = System.Drawing.Color.White;
            this.panelVinto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVinto.Controls.Add(this.panel4);
            this.panelVinto.Controls.Add(this.label1);
            this.panelVinto.Location = new System.Drawing.Point(93, 636);
            this.panelVinto.Margin = new System.Windows.Forms.Padding(4);
            this.panelVinto.Name = "panelVinto";
            this.panelVinto.Size = new System.Drawing.Size(798, 260);
            this.panelVinto.TabIndex = 28;
            this.panelVinto.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(527, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 158);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 50F);
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hai vinto";
            // 
            // txtInsert
            // 
            this.txtInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsert.Location = new System.Drawing.Point(621, 496);
            this.txtInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(145, 136);
            this.txtInsert.TabIndex = 32;
            this.txtInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInsert.Visible = false;
            this.txtInsert.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "RESTART-APP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDescrNome
            // 
            this.lblDescrNome.AutoSize = true;
            this.lblDescrNome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrNome.Location = new System.Drawing.Point(4, 11);
            this.lblDescrNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrNome.Name = "lblDescrNome";
            this.lblDescrNome.Size = new System.Drawing.Size(139, 29);
            this.lblDescrNome.TabIndex = 34;
            this.lblDescrNome.Text = "Username:";
            // 
            // lblDescrPts
            // 
            this.lblDescrPts.AutoSize = true;
            this.lblDescrPts.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrPts.Location = new System.Drawing.Point(4, 39);
            this.lblDescrPts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrPts.Name = "lblDescrPts";
            this.lblDescrPts.Size = new System.Drawing.Size(153, 29);
            this.lblDescrPts.TabIndex = 35;
            this.lblDescrPts.Text = "Punteggio:";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelInfo.Controls.Add(this.labelPts);
            this.panelInfo.Controls.Add(this.lblDescrPts);
            this.panelInfo.Controls.Add(this.labelNome);
            this.panelInfo.Controls.Add(this.lblDescrNome);
            this.panelInfo.Location = new System.Drawing.Point(413, 213);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(648, 73);
            this.panelInfo.TabIndex = 36;
            this.panelInfo.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 37;
            this.button2.Text = "DELETE DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(0, 200);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(122, 41);
            this.buttonSettings.TabIndex = 38;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1940, 965);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.panelPerso);
            this.Controls.Add(this.panelVinto);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2560, 1280);
            this.MinimumSize = new System.Drawing.Size(348, 75);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ffff";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressKey);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelVolumeInside.ResumeLayout(false);
            this.panelPerso.ResumeLayout(false);
            this.panelPerso.PerformLayout();
            this.panelVinto.ResumeLayout(false);
            this.panelVinto.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelTitle;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Button buttonPlay;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.CyberTextBox BackNickname;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label labelPts;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelVolume;
        private ReaLTaiizor.Controls.MaterialScrollBar hScrollVolume;
        private ReaLTaiizor.Controls.Panel panelSettings;
        private ReaLTaiizor.Controls.Panel panelVolumeInside;
        private System.Windows.Forms.Panel panelPerso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelVinto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNickname;
        private ReaLTaiizor.Controls.MaterialScrollBar ScrollVolume;
        private System.Windows.Forms.Label lblDescrPts;
        private System.Windows.Forms.Label lblDescrNome;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSettings;
    }
}

