
namespace Program2
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
            this.btnrev = new System.Windows.Forms.Button();
            this.btntrim = new System.Windows.Forms.Button();
            this.btnpad = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnrev
            // 
            this.btnrev.Location = new System.Drawing.Point(263, 266);
            this.btnrev.Name = "btnrev";
            this.btnrev.Size = new System.Drawing.Size(75, 23);
            this.btnrev.TabIndex = 0;
            this.btnrev.Text = "Reverse";
            this.btnrev.UseVisualStyleBackColor = true;
            this.btnrev.Click += new System.EventHandler(this.btnrev_Click);
            // 
            // btntrim
            // 
            this.btntrim.Location = new System.Drawing.Point(373, 265);
            this.btntrim.Name = "btntrim";
            this.btntrim.Size = new System.Drawing.Size(75, 23);
            this.btntrim.TabIndex = 1;
            this.btntrim.Text = "Trim";
            this.btntrim.UseVisualStyleBackColor = true;
            this.btntrim.Click += new System.EventHandler(this.btntrim_Click);
            // 
            // btnpad
            // 
            this.btnpad.Location = new System.Drawing.Point(478, 266);
            this.btnpad.Name = "btnpad";
            this.btnpad.Size = new System.Drawing.Size(94, 24);
            this.btnpad.TabIndex = 2;
            this.btnpad.Text = "Pad";
            this.btnpad.UseVisualStyleBackColor = true;
            this.btnpad.Click += new System.EventHandler(this.btnpad_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(425, 172);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(147, 22);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "Technology";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(279, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input string";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "STRING OPERATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnpad);
            this.Controls.Add(this.btntrim);
            this.Controls.Add(this.btnrev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrev;
        private System.Windows.Forms.Button btntrim;
        private System.Windows.Forms.Button btnpad;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

