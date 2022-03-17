
namespace Program1
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
            this.lbl_words = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_words
            // 
            this.lbl_words.AutoSize = true;
            this.lbl_words.Location = new System.Drawing.Point(494, 118);
            this.lbl_words.Name = "lbl_words";
            this.lbl_words.Size = new System.Drawing.Size(35, 13);
            this.lbl_words.TabIndex = 0;
            this.lbl_words.Text = "label1";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(477, 160);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 1;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(497, 206);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 2;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_words);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_words;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button convert;
    }
}

