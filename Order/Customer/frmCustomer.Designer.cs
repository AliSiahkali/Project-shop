namespace Order.Customer
{
    partial class frmCustomer
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.rgvCustomer = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCustomer.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(752, 80);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "افزودن";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(191)))), ((int)(((byte)(1)))));
            this.commandBarRowElement1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarButton2,
            this.commandBarButton3});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.DrawText = true;
            this.commandBarButton1.Image = global::Order.Properties.Resources.if_simpline_2_2305585;
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "اضافه کردن";
            this.commandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton1.Click += new System.EventHandler(this.commandBarButton1_Click);
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.DisplayName = "commandBarButton2";
            this.commandBarButton2.DrawText = true;
            this.commandBarButton2.Image = global::Order.Properties.Resources.if_simpline_39_2305601_1;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "ویرایش";
            this.commandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton2.Click += new System.EventHandler(this.commandBarButton2_Click);
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.DisplayName = "commandBarButton3";
            this.commandBarButton3.DrawText = true;
            this.commandBarButton3.Image = global::Order.Properties.Resources.if_simpline_21_2305593_2;
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "حذف کردن";
            this.commandBarButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton3.Click += new System.EventHandler(this.commandBarButton3_Click);
            // 
            // rgvCustomer
            // 
            this.rgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvCustomer.Location = new System.Drawing.Point(0, 80);
            // 
            // 
            // 
            this.rgvCustomer.MasterTemplate.AllowAddNewRow = false;
            this.rgvCustomer.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "customerID";
            gridViewTextBoxColumn1.HeaderText = "شماره مشتری";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "نام";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 147;
            gridViewTextBoxColumn3.FieldName = "Family";
            gridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 147;
            gridViewTextBoxColumn4.FieldName = "Mobile";
            gridViewTextBoxColumn4.HeaderText = "موبایل";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 147;
            gridViewTextBoxColumn5.FieldName = "Adress";
            gridViewTextBoxColumn5.HeaderText = "آدرس";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 147;
            gridViewTextBoxColumn6.FieldName = "Note";
            gridViewTextBoxColumn6.HeaderText = "تضیحات";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 147;
            this.rgvCustomer.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.rgvCustomer.MasterTemplate.EnableFiltering = true;
            this.rgvCustomer.MasterTemplate.EnableGrouping = false;
            this.rgvCustomer.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvCustomer.Name = "rgvCustomer";
            this.rgvCustomer.ReadOnly = true;
            this.rgvCustomer.Size = new System.Drawing.Size(752, 336);
            this.rgvCustomer.TabIndex = 1;
            this.rgvCustomer.Text = "radGridView1";
            this.rgvCustomer.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 416);
            this.Controls.Add(this.rgvCustomer);
            this.Controls.Add(this.radCommandBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت مشتریان";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCustomer.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.RadGridView rgvCustomer;



    }
}