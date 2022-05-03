namespace Order
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.BackgroundImage = global::Order.Properties.Resources.photoshop_store_avatar_2_1x;
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Font = new System.Drawing.Font("B Zar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBar1.Size = new System.Drawing.Size(659, 155);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 3;
            this.radRibbonBar1.Text = "فروشگاه";
            this.radRibbonBar1.ThemeName = "TelerikMetro";
            this.radRibbonBar1.Click += new System.EventHandler(this.radRibbonBar1_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = false;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "محصولات";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "کالاها";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Image = global::Order.Properties.Resources.if_simpline_41_2305621_1;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "";
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.IsSelected = true;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "تنظیمات";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "مدیریت کاربران";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Image = global::Order.Properties.Resources.if_simpline_27_2305630;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.StretchVertically = true;
            this.radButtonElement3.Text = "";
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement4});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "مشتریان";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.Image = global::Order.Properties.Resources.if_simpline_13_2305639_1;
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "";
            this.radButtonElement4.Click += new System.EventHandler(this.radButtonElement4_Click);
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "نرم افزار مدیریت فروشگاه";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Order.Properties.Resources.photoshop_store_avatar_2_1x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 357);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.Text = "فروشگاه";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        public Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}