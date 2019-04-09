namespace Boje
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
            this.UnosBoje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaBoja = new System.Windows.Forms.ListBox();
            this.DodajBojuGumb = new System.Windows.Forms.Button();
            this.PromijeniBojuGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnosBoje
            // 
            this.UnosBoje.Location = new System.Drawing.Point(26, 45);
            this.UnosBoje.Name = "UnosBoje";
            this.UnosBoje.Size = new System.Drawing.Size(100, 20);
            this.UnosBoje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi boju";
            // 
            // listaBoja
            // 
            this.listaBoja.FormattingEnabled = true;
            this.listaBoja.Location = new System.Drawing.Point(26, 99);
            this.listaBoja.Name = "listaBoja";
            this.listaBoja.Size = new System.Drawing.Size(178, 251);
            this.listaBoja.TabIndex = 2;
            // 
            // DodajBojuGumb
            // 
            this.DodajBojuGumb.Location = new System.Drawing.Point(158, 45);
            this.DodajBojuGumb.Name = "DodajBojuGumb";
            this.DodajBojuGumb.Size = new System.Drawing.Size(88, 34);
            this.DodajBojuGumb.TabIndex = 3;
            this.DodajBojuGumb.Text = "Dodaj boju";
            this.DodajBojuGumb.UseVisualStyleBackColor = true;
            this.DodajBojuGumb.Click += new System.EventHandler(this.DodajBojuGumb_Click);
            // 
            // PromijeniBojuGumb
            // 
            this.PromijeniBojuGumb.Location = new System.Drawing.Point(327, 39);
            this.PromijeniBojuGumb.Name = "PromijeniBojuGumb";
            this.PromijeniBojuGumb.Size = new System.Drawing.Size(99, 69);
            this.PromijeniBojuGumb.TabIndex = 4;
            this.PromijeniBojuGumb.Text = "Promijeni boju";
            this.PromijeniBojuGumb.UseVisualStyleBackColor = true;
            this.PromijeniBojuGumb.Click += new System.EventHandler(this.PromijeniBojuGumb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PromijeniBojuGumb);
            this.Controls.Add(this.DodajBojuGumb);
            this.Controls.Add(this.listaBoja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosBoje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnosBoje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaBoja;
        private System.Windows.Forms.Button DodajBojuGumb;
        private System.Windows.Forms.Button PromijeniBojuGumb;
    }
}

