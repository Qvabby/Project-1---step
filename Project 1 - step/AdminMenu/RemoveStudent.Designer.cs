namespace Project_1___step.AdminMenu
{
    partial class RemoveStudent
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
            this.Removeitbtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.RemoveIdNUAD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveIdNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // Removeitbtn
            // 
            this.Removeitbtn.Location = new System.Drawing.Point(12, 110);
            this.Removeitbtn.Name = "Removeitbtn";
            this.Removeitbtn.Size = new System.Drawing.Size(75, 23);
            this.Removeitbtn.TabIndex = 18;
            this.Removeitbtn.Text = "Remove";
            this.Removeitbtn.UseVisualStyleBackColor = true;
            this.Removeitbtn.Click += new System.EventHandler(this.Removeitbtn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(80, 50);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 17;
            this.IdLabel.Text = "Id:";
            // 
            // RemoveIdNUAD
            // 
            this.RemoveIdNUAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveIdNUAD.Location = new System.Drawing.Point(126, 48);
            this.RemoveIdNUAD.Name = "RemoveIdNUAD";
            this.RemoveIdNUAD.Size = new System.Drawing.Size(108, 26);
            this.RemoveIdNUAD.TabIndex = 16;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 189);
            this.Controls.Add(this.Removeitbtn);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.RemoveIdNUAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveStudent";
            this.Text = "RemoveStudent";
            ((System.ComponentModel.ISupportInitialize)(this.RemoveIdNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Removeitbtn;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.NumericUpDown RemoveIdNUAD;
    }
}