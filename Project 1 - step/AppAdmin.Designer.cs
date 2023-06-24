namespace Project_1___step
{
    partial class AppAdmin
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.ShowStudentsBtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(12, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 39);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Student";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(12, 79);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(137, 39);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove Student";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Location = new System.Drawing.Point(12, 316);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.Size = new System.Drawing.Size(260, 61);
            this.StudentsDGV.TabIndex = 8;
            // 
            // ShowStudentsBtn
            // 
            this.ShowStudentsBtn.Location = new System.Drawing.Point(303, 338);
            this.ShowStudentsBtn.Name = "ShowStudentsBtn";
            this.ShowStudentsBtn.Size = new System.Drawing.Size(89, 23);
            this.ShowStudentsBtn.TabIndex = 9;
            this.ShowStudentsBtn.Text = "Show Students";
            this.ShowStudentsBtn.UseVisualStyleBackColor = true;
            this.ShowStudentsBtn.Click += new System.EventHandler(this.ShowStudentsBtn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(522, 21);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id:";
            this.IdLabel.Visible = false;
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(12, 145);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update Student";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(155, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(404, 172);
            this.MenuPanel.TabIndex = 28;
            // 
            // AppAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 389);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.ShowStudentsBtn);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppAdmin";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Button ShowStudentsBtn;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel MenuPanel;
    }
}