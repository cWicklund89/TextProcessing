namespace TextProcessing
{
    partial class CartForm
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
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.Image = global::TextProcessing.Properties.Resources.cart_plus;
            this.shoppingCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shoppingCartButton.Location = new System.Drawing.Point(267, 60);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(248, 57);
            this.shoppingCartButton.TabIndex = 0;
            this.shoppingCartButton.Text = "Add to Shopping Cart";
            this.shoppingCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shoppingCartButton.UseVisualStyleBackColor = true;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shoppingCartButton);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shoppingCartButton;
    }
}