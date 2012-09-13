﻿namespace MetroFramework.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroScrollBar2 = new MetroFramework.Controls.MetroScrollBar();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(23, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(129, 27);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = this.metroStyleManager;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "SWITCH THEME";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton2
            // 
            this.metroButton2.Enabled = false;
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(23, 96);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(129, 27);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = this.metroStyleManager;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "DISABLED";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(23, 129);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(129, 27);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.StyleManager = this.metroStyleManager;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "SWITCH STYLE";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(222, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 90);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.StyleManager = this.metroStyleManager;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Red";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 3;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(318, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(90, 90);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.StyleManager = this.metroStyleManager;
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Green";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(222, 159);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(186, 90);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.StyleManager = this.metroStyleManager;
            this.metroTile3.TabIndex = 6;
            this.metroTile3.Text = "Settings";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.TileCount = 0;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink1.Location = new System.Drawing.Point(427, 63);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(144, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.StyleManager = this.metroStyleManager;
            this.metroLink1.TabIndex = 7;
            this.metroLink1.Text = "Lime";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseStyleColors = false;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Enabled = false;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink2.Location = new System.Drawing.Point(427, 92);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(144, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink2.StyleManager = this.metroStyleManager;
            this.metroLink2.TabIndex = 8;
            this.metroLink2.Text = "metroLink2";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink2.UseStyleColors = false;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroLink3.Location = new System.Drawing.Point(427, 121);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(144, 23);
            this.metroLink3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink3.StyleManager = this.metroStyleManager;
            this.metroLink3.TabIndex = 9;
            this.metroLink3.Text = "Silver";
            this.metroLink3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink3.UseStyleColors = false;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(222, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 100);
            this.panel1.TabIndex = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(279, 406);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(129, 27);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.StyleManager = this.metroStyleManager;
            this.metroButton4.TabIndex = 11;
            this.metroButton4.Text = "BLEND COLOR";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.Location = new System.Drawing.Point(222, 274);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(186, 23);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = this.metroStyleManager;
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Color&BlejndAnimation Demo";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.Location = new System.Drawing.Point(23, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 37);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = this.metroStyleManager;
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "metroLabel2";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.Location = new System.Drawing.Point(23, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(149, 37);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = this.metroStyleManager;
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "metroLabel3";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.Location = new System.Drawing.Point(23, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(149, 37);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = this.metroStyleManager;
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "metroLabel4";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLink4
            // 
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink4.Location = new System.Drawing.Point(463, 150);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(99, 39);
            this.metroLink4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink4.StyleManager = this.metroStyleManager;
            this.metroLink4.TabIndex = 16;
            this.metroLink4.Text = "metroLink4";
            this.metroLink4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink4.UseStyleColors = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.LargeChange = ((uint)(5u));
            this.metroTrackBar1.Location = new System.Drawing.Point(453, 278);
            this.metroTrackBar1.Maximum = 100;
            this.metroTrackBar1.Minimum = 0;
            this.metroTrackBar1.MouseWheelBarPartitions = 10;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(167, 31);
            this.metroTrackBar1.SmallChange = ((uint)(1u));
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTrackBar1.StyleManager = this.metroStyleManager;
            this.metroTrackBar1.TabIndex = 18;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar1.Value = 50;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar2.Enabled = false;
            this.metroTrackBar2.LargeChange = ((uint)(5u));
            this.metroTrackBar2.Location = new System.Drawing.Point(453, 315);
            this.metroTrackBar2.Maximum = 100;
            this.metroTrackBar2.Minimum = 0;
            this.metroTrackBar2.MouseWheelBarPartitions = 10;
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(167, 31);
            this.metroTrackBar2.SmallChange = ((uint)(1u));
            this.metroTrackBar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTrackBar2.StyleManager = this.metroStyleManager;
            this.metroTrackBar2.TabIndex = 19;
            this.metroTrackBar2.Text = "metroTrackBar2";
            this.metroTrackBar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar2.Value = 50;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(453, 353);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = this.metroStyleManager;
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "metroLabel5";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroCheckBox1.Location = new System.Drawing.Point(605, 63);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(180, 17);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox1.StyleManager = this.metroStyleManager;
            this.metroCheckBox1.TabIndex = 21;
            this.metroCheckBox1.Text = "Enable other Checkboxes";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox1.UseStyleColors = false;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroCheckBox2.Location = new System.Drawing.Point(605, 86);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(180, 17);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox2.StyleManager = this.metroStyleManager;
            this.metroCheckBox2.TabIndex = 22;
            this.metroCheckBox2.Text = "metroCheckBox2";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox2.UseStyleColors = false;
            this.metroCheckBox2.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.Enabled = false;
            this.metroCheckBox3.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox3.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroCheckBox3.Location = new System.Drawing.Point(605, 109);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(180, 17);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox3.StyleManager = this.metroStyleManager;
            this.metroCheckBox3.TabIndex = 23;
            this.metroCheckBox3.Text = "metroCheckBox3";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox3.UseStyleColors = false;
            this.metroCheckBox3.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox4.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroCheckBox4.Location = new System.Drawing.Point(605, 132);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(180, 17);
            this.metroCheckBox4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox4.StyleManager = this.metroStyleManager;
            this.metroCheckBox4.TabIndex = 24;
            this.metroCheckBox4.Text = "metroCheckBox4";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox4.UseStyleColors = true;
            this.metroCheckBox4.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroCheckBox5.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroCheckBox5.Location = new System.Drawing.Point(605, 155);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(180, 17);
            this.metroCheckBox5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox5.StyleManager = this.metroStyleManager;
            this.metroCheckBox5.TabIndex = 25;
            this.metroCheckBox5.Text = "metroCheckBox5";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBox5.UseStyleColors = false;
            this.metroCheckBox5.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroRadioButton1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroRadioButton1.Location = new System.Drawing.Point(605, 198);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(116, 17);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroRadioButton1.StyleManager = this.metroStyleManager;
            this.metroRadioButton1.TabIndex = 26;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "metroRadioButton1";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroRadioButton1.UseStyleColors = false;
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroRadioButton2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroRadioButton2.Location = new System.Drawing.Point(605, 221);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(116, 17);
            this.metroRadioButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroRadioButton2.StyleManager = this.metroStyleManager;
            this.metroRadioButton2.TabIndex = 27;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "metroRadioButton2";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroRadioButton2.UseStyleColors = false;
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.metroScrollBar1.LargeChange = 5;
            this.metroScrollBar1.Location = new System.Drawing.Point(23, 547);
            this.metroScrollBar1.Maximum = 10;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.ScrollBarOrientation.Horizontal;
            this.metroScrollBar1.Size = new System.Drawing.Size(824, 6);
            this.metroScrollBar1.SmallChange = 1;
            this.metroScrollBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollBar1.StyleManager = this.metroStyleManager;
            this.metroScrollBar1.TabIndex = 28;
            this.metroScrollBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScrollBar1.UseBarColor = true;
            this.metroScrollBar1.Value = 10;
            // 
            // metroScrollBar2
            // 
            this.metroScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.metroScrollBar2.LargeChange = 5;
            this.metroScrollBar2.Location = new System.Drawing.Point(853, 63);
            this.metroScrollBar2.Maximum = 10;
            this.metroScrollBar2.Minimum = 0;
            this.metroScrollBar2.MouseWheelBarPartitions = 10;
            this.metroScrollBar2.Name = "metroScrollBar2";
            this.metroScrollBar2.Orientation = MetroFramework.Controls.ScrollBarOrientation.Vertical;
            this.metroScrollBar2.Size = new System.Drawing.Size(6, 480);
            this.metroScrollBar2.SmallChange = 1;
            this.metroScrollBar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollBar2.StyleManager = this.metroStyleManager;
            this.metroScrollBar2.TabIndex = 29;
            this.metroScrollBar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScrollBar2.UseBarColor = false;
            this.metroScrollBar2.Value = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.Location = new System.Drawing.Point(491, 498);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(164, 23);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = this.metroStyleManager;
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "metroLabel6";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox1.Location = new System.Drawing.Point(491, 473);
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(164, 22);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.StyleManager = this.metroStyleManager;
            this.metroTextBox1.TabIndex = 32;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseStyleColors = false;
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 566);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroScrollBar2);
            this.Controls.Add(this.metroScrollBar1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "MainForm";
            this.StyleManager = this.metroStyleManager;
            this.Text = "metro framework";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
