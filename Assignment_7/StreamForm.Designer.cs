namespace Assignment_7
{
    partial class StreamForm_
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
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.StreamingLabel = new System.Windows.Forms.Label();
            this.ChargedLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(126, 8);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(370, 22);
            this.ThankYouLabel.TabIndex = 0;
            this.ThankYouLabel.Text = "Thank you for choosing Movie Bonanza";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(183, 177);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(84, 35);
            this.OkButton.TabIndex = 14;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.AutoSize = true;
            this.ChargeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeLabel.Location = new System.Drawing.Point(126, 63);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(330, 22);
            this.ChargeLabel.TabIndex = 15;
            this.ChargeLabel.Text = "Your Credit card will be charged";
            // 
            // StreamingLabel
            // 
            this.StreamingLabel.AutoSize = true;
            this.StreamingLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamingLabel.Location = new System.Drawing.Point(356, 113);
            this.StreamingLabel.Name = "StreamingLabel";
            this.StreamingLabel.Size = new System.Drawing.Size(290, 22);
            this.StreamingLabel.TabIndex = 16;
            this.StreamingLabel.Text = "will begin streaming shortly";
            // 
            // ChargedLabel
            // 
            this.ChargedLabel.AutoSize = true;
            this.ChargedLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargedLabel.Location = new System.Drawing.Point(477, 63);
            this.ChargedLabel.Name = "ChargedLabel";
            this.ChargedLabel.Size = new System.Drawing.Size(70, 22);
            this.ChargedLabel.TabIndex = 17;
            this.ChargedLabel.Text = "Amount";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(126, 113);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(60, 22);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Title";
            // 
            // StreamForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 320);
            this.ControlBox = false;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ChargedLabel);
            this.Controls.Add(this.StreamingLabel);
            this.Controls.Add(this.ChargeLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ThankYouLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm_";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ChargeLabel;
        private System.Windows.Forms.Label StreamingLabel;
        private System.Windows.Forms.Label ChargedLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}