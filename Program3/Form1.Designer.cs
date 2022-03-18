
namespace Program3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnrev = new System.Windows.Forms.Button();
            this.btntrim = new System.Windows.Forms.Button();
            this.Pad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STRING OPERATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input String";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(440, 128);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 2;
            this.txtinput.Text = "Technology";
            // 
            // btnrev
            // 
            this.btnrev.Location = new System.Drawing.Point(306, 186);
            this.btnrev.Name = "btnrev";
            this.btnrev.Size = new System.Drawing.Size(75, 23);
            this.btnrev.TabIndex = 3;
            this.btnrev.Text = "Reverse";
            this.btnrev.UseVisualStyleBackColor = true;
            this.btnrev.Click += new System.EventHandler(this.btnrev_Click);
            // 
            // btntrim
            // 
            this.btntrim.Location = new System.Drawing.Point(402, 186);
            this.btntrim.Name = "btntrim";
            this.btntrim.Size = new System.Drawing.Size(75, 23);
            this.btntrim.TabIndex = 4;
            this.btntrim.Text = "Trim";
            this.btntrim.UseVisualStyleBackColor = true;
            this.btntrim.Click += new System.EventHandler(this.btntrim_Click);
            // 
            // Pad
            // 
            this.Pad.Location = new System.Drawing.Point(497, 186);
            this.Pad.Name = "Pad";
            this.Pad.Size = new System.Drawing.Size(75, 23);
            this.Pad.TabIndex = 5;
            this.Pad.Text = "btnpad";
            this.Pad.UseVisualStyleBackColor = true;
            this.Pad.Click += new System.EventHandler(this.Pad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pad);
            this.Controls.Add(this.btntrim);
            this.Controls.Add(this.btnrev);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnrev;
        private System.Windows.Forms.Button btntrim;
        private System.Windows.Forms.Button Pad;
    }
}

