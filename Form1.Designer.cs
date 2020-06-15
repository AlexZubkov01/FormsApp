namespace FormsApp
{
    partial class Form1
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
            this.labelPro = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Location = new System.Drawing.Point(234, 177);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(97, 25);
            this.labelPro.TabIndex = 0;
            this.labelPro.Text = "something";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(283, 223);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(182, 34);
            this.actionButton.TabIndex = 1;
            this.actionButton.Text = "do somthing";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.labelPro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPro;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

