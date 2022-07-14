
namespace IB_ThreadingPlatform
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ContractListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Contract    Details";
            // 
            // ContractListBox
            // 
            this.ContractListBox.FormattingEnabled = true;
            this.ContractListBox.HorizontalScrollbar = true;
            this.ContractListBox.ItemHeight = 15;
            this.ContractListBox.Location = new System.Drawing.Point(60, 87);
            this.ContractListBox.Name = "ContractListBox";
            this.ContractListBox.Size = new System.Drawing.Size(449, 319);
            this.ContractListBox.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 447);
            this.Controls.Add(this.ContractListBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();


        }
        
        #endregion.

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListBox ContractListBox;
    }
}