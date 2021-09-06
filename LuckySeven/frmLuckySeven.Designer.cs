namespace LuckySeven
{
    partial class frmLuckySeven
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuckySeven));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtDigit1 = new System.Windows.Forms.TextBox();
            this.txtDigit2 = new System.Windows.Forms.TextBox();
            this.txtDigit3 = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(44, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credits:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblCredits.Location = new System.Drawing.Point(184, 145);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(137, 75);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "xxx";
            // 
            // txtDigit1
            // 
            this.txtDigit1.BackColor = System.Drawing.Color.ForestGreen;
            this.txtDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigit1.Location = new System.Drawing.Point(83, 252);
            this.txtDigit1.Name = "txtDigit1";
            this.txtDigit1.ReadOnly = true;
            this.txtDigit1.Size = new System.Drawing.Size(108, 219);
            this.txtDigit1.TabIndex = 0;
            this.txtDigit1.TabStop = false;
            this.txtDigit1.Text = "8";
            this.txtDigit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDigit2
            // 
            this.txtDigit2.BackColor = System.Drawing.Color.ForestGreen;
            this.txtDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigit2.Location = new System.Drawing.Point(197, 252);
            this.txtDigit2.Name = "txtDigit2";
            this.txtDigit2.ReadOnly = true;
            this.txtDigit2.Size = new System.Drawing.Size(108, 219);
            this.txtDigit2.TabIndex = 2;
            this.txtDigit2.TabStop = false;
            this.txtDigit2.Text = "8";
            this.txtDigit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDigit3
            // 
            this.txtDigit3.BackColor = System.Drawing.Color.ForestGreen;
            this.txtDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigit3.Location = new System.Drawing.Point(311, 252);
            this.txtDigit3.Name = "txtDigit3";
            this.txtDigit3.ReadOnly = true;
            this.txtDigit3.Size = new System.Drawing.Size(108, 219);
            this.txtDigit3.TabIndex = 3;
            this.txtDigit3.TabStop = false;
            this.txtDigit3.Text = "8";
            this.txtDigit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSpin.Location = new System.Drawing.Point(159, 489);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(184, 71);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "&Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.SpinClick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(371, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "xxx";
            // 
            // frmLuckySeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 585);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtDigit3);
            this.Controls.Add(this.txtDigit2);
            this.Controls.Add(this.txtDigit1);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLuckySeven";
            this.Text = "Lucky Seven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtDigit1;
        private System.Windows.Forms.TextBox txtDigit2;
        private System.Windows.Forms.TextBox txtDigit3;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblResult;
    }
}

