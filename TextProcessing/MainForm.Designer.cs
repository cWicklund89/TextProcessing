namespace TextProcessing
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cart-plus.png");
            this.imageList1.Images.SetKeyName(1, "exit-run.png");
            this.imageList1.Images.SetKeyName(2, "file-delimited-outline.png");
            this.imageList1.Images.SetKeyName(3, "login-variant.png");
            this.imageList1.Images.SetKeyName(4, "logout-variant.png");
            this.imageList1.Images.SetKeyName(5, "microsoft-excel.png");
            this.imageList1.Images.SetKeyName(6, "numeric-1-box-outline.png");
            this.imageList1.Images.SetKeyName(7, "numeric-2-box-outline.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.menuOption1ToolStripMenuItem,
            this.menuOption2ToolStripMenuItem,
            this.cSVDisplayToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.exit_run;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuOption1ToolStripMenuItem
            // 
            this.menuOption1ToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.numeric_1_box_outline;
            this.menuOption1ToolStripMenuItem.Name = "menuOption1ToolStripMenuItem";
            this.menuOption1ToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.menuOption1ToolStripMenuItem.Text = "Menu Option 1";
            // 
            // menuOption2ToolStripMenuItem
            // 
            this.menuOption2ToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.numeric_2_box_outline;
            this.menuOption2ToolStripMenuItem.Name = "menuOption2ToolStripMenuItem";
            this.menuOption2ToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.menuOption2ToolStripMenuItem.Text = "Menu Option 2";
            this.menuOption2ToolStripMenuItem.Click += new System.EventHandler(this.menuOption2ToolStripMenuItem_Click);
            // 
            // cSVDisplayToolStripMenuItem
            // 
            this.cSVDisplayToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.microsoft_excel;
            this.cSVDisplayToolStripMenuItem.Name = "cSVDisplayToolStripMenuItem";
            this.cSVDisplayToolStripMenuItem.Size = new System.Drawing.Size(193, 38);
            this.cSVDisplayToolStripMenuItem.Text = "CSV Display";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.login_variant;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Image = global::TextProcessing.Properties.Resources.logout_variant;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(141, 38);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Text Processing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOption1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOption2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

