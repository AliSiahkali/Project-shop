namespace Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtusername = new Telerik.WinControls.UI.RadTextBox();
            this.txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnlogin = new Telerik.WinControls.UI.RadButton();
            this.btncancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // radLabel2
            // 
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            // 
            // txtusername
            // 
            resources.ApplyResources(this.txtusername, "txtusername");
            this.txtusername.Name = "txtusername";
            // 
            // txtpassword
            // 
            resources.ApplyResources(this.txtpassword, "txtpassword");
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            // 
            // btnlogin
            // 
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            resources.ApplyResources(this.btncancel, "btncancel");
            this.btncancel.Name = "btncancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Order.Properties.Resources.photoshop_store_avatar_2_1x;
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtusername;
        private Telerik.WinControls.UI.RadTextBox txtpassword;
        private Telerik.WinControls.UI.RadButton btnlogin;
        private Telerik.WinControls.UI.RadButton btncancel;
    }
}

