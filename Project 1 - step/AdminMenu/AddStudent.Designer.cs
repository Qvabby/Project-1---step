namespace Project_1___step.AdminMenu
{
    partial class AddStudent
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
            this.AdditBtn = new System.Windows.Forms.Button();
            this.GroupIDNUAD = new System.Windows.Forms.NumericUpDown();
            this.StudentGroupLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // AdditBtn
            // 
            this.AdditBtn.Location = new System.Drawing.Point(210, 126);
            this.AdditBtn.Name = "AdditBtn";
            this.AdditBtn.Size = new System.Drawing.Size(75, 23);
            this.AdditBtn.TabIndex = 21;
            this.AdditBtn.Text = "Add";
            this.AdditBtn.UseVisualStyleBackColor = true;
            this.AdditBtn.Click += new System.EventHandler(this.AdditBtn_Click);
            // 
            // GroupIDNUAD
            // 
            this.GroupIDNUAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupIDNUAD.Location = new System.Drawing.Point(165, 94);
            this.GroupIDNUAD.Name = "GroupIDNUAD";
            this.GroupIDNUAD.Size = new System.Drawing.Size(120, 26);
            this.GroupIDNUAD.TabIndex = 20;
            // 
            // StudentGroupLabel
            // 
            this.StudentGroupLabel.AutoSize = true;
            this.StudentGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGroupLabel.Location = new System.Drawing.Point(12, 94);
            this.StudentGroupLabel.Name = "StudentGroupLabel";
            this.StudentGroupLabel.Size = new System.Drawing.Size(129, 20);
            this.StudentGroupLabel.TabIndex = 19;
            this.StudentGroupLabel.Text = "Student GroupId";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 62);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(147, 20);
            this.LastNameLabel.TabIndex = 18;
            this.LastNameLabel.Text = "Student LastName:";
            // 
            // LastNameTb
            // 
            this.LastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTb.Location = new System.Drawing.Point(165, 59);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(223, 26);
            this.LastNameTb.TabIndex = 17;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 20);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Student Name:";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(165, 24);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(223, 26);
            this.NameTb.TabIndex = 15;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 172);
            this.Controls.Add(this.AdditBtn);
            this.Controls.Add(this.GroupIDNUAD);
            this.Controls.Add(this.StudentGroupLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.GroupIDNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdditBtn;
        private System.Windows.Forms.NumericUpDown GroupIDNUAD;
        private System.Windows.Forms.Label StudentGroupLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTb;
    }
}