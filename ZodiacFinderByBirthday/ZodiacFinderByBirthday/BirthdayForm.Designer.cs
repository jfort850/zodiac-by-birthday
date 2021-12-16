
namespace ZodiacFinderByBirthday
{
    partial class frmBirthday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBirthday));
            this.btnFindZodiac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFindZodiac
            // 
            this.btnFindZodiac.BackColor = System.Drawing.Color.Transparent;
            this.btnFindZodiac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindZodiac.BackgroundImage")));
            this.btnFindZodiac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindZodiac.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFindZodiac.ForeColor = System.Drawing.Color.Black;
            this.btnFindZodiac.Image = ((System.Drawing.Image)(resources.GetObject("btnFindZodiac.Image")));
            this.btnFindZodiac.Location = new System.Drawing.Point(131, 104);
            this.btnFindZodiac.Name = "btnFindZodiac";
            this.btnFindZodiac.Size = new System.Drawing.Size(115, 39);
            this.btnFindZodiac.TabIndex = 11;
            this.btnFindZodiac.Text = "Find Zodiac";
            this.btnFindZodiac.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Birthday";
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtBirthDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBirthDay.Location = new System.Drawing.Point(12, 41);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(357, 20);
            this.txtBirthDay.TabIndex = 13;
            // 
            // frmBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 186);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindZodiac);
            this.Name = "frmBirthday";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindZodiac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirthDay;
    }
}