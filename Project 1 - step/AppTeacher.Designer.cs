namespace Project_1___step
{
    partial class AppTeacher
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
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.AddPointBtn = new System.Windows.Forms.Button();
            this.StudIdLabel = new System.Windows.Forms.Label();
            this.StudPointLabel = new System.Windows.Forms.Label();
            this.IdNUAD = new System.Windows.Forms.NumericUpDown();
            this.PointNUAD = new System.Windows.Forms.NumericUpDown();
            this.AddBtn = new System.Windows.Forms.Button();
            this.GroupsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Location = new System.Drawing.Point(12, 34);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.Size = new System.Drawing.Size(530, 343);
            this.StudentsDGV.TabIndex = 0;
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Location = new System.Drawing.Point(12, 18);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(52, 13);
            this.StudentsLabel.TabIndex = 1;
            this.StudentsLabel.Text = "Students:";
            // 
            // AddPointBtn
            // 
            this.AddPointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPointBtn.Location = new System.Drawing.Point(552, 248);
            this.AddPointBtn.Name = "AddPointBtn";
            this.AddPointBtn.Size = new System.Drawing.Size(110, 33);
            this.AddPointBtn.TabIndex = 2;
            this.AddPointBtn.Text = "Add Point";
            this.AddPointBtn.UseVisualStyleBackColor = true;
            this.AddPointBtn.Click += new System.EventHandler(this.AddPointBtn_Click);
            // 
            // StudIdLabel
            // 
            this.StudIdLabel.AutoSize = true;
            this.StudIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudIdLabel.Location = new System.Drawing.Point(552, 298);
            this.StudIdLabel.Name = "StudIdLabel";
            this.StudIdLabel.Size = new System.Drawing.Size(88, 20);
            this.StudIdLabel.TabIndex = 3;
            this.StudIdLabel.Text = "Student Id:";
            this.StudIdLabel.Visible = false;
            // 
            // StudPointLabel
            // 
            this.StudPointLabel.AutoSize = true;
            this.StudPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudPointLabel.Location = new System.Drawing.Point(552, 331);
            this.StudPointLabel.Name = "StudPointLabel";
            this.StudPointLabel.Size = new System.Drawing.Size(110, 20);
            this.StudPointLabel.TabIndex = 4;
            this.StudPointLabel.Text = "Student Point:";
            this.StudPointLabel.Visible = false;
            // 
            // IdNUAD
            // 
            this.IdNUAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNUAD.Location = new System.Drawing.Point(646, 292);
            this.IdNUAD.Name = "IdNUAD";
            this.IdNUAD.Size = new System.Drawing.Size(104, 26);
            this.IdNUAD.TabIndex = 5;
            this.IdNUAD.Visible = false;
            // 
            // PointNUAD
            // 
            this.PointNUAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointNUAD.Location = new System.Drawing.Point(668, 324);
            this.PointNUAD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.PointNUAD.Name = "PointNUAD";
            this.PointNUAD.Size = new System.Drawing.Size(82, 26);
            this.PointNUAD.TabIndex = 6;
            this.PointNUAD.Visible = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(552, 354);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // GroupsCB
            // 
            this.GroupsCB.FormattingEnabled = true;
            this.GroupsCB.Location = new System.Drawing.Point(552, 50);
            this.GroupsCB.Name = "GroupsCB";
            this.GroupsCB.Size = new System.Drawing.Size(121, 21);
            this.GroupsCB.TabIndex = 9;
            this.GroupsCB.SelectedIndexChanged += new System.EventHandler(this.GroupsCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Groups:";
            // 
            // AppTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupsCB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PointNUAD);
            this.Controls.Add(this.IdNUAD);
            this.Controls.Add(this.StudPointLabel);
            this.Controls.Add(this.StudIdLabel);
            this.Controls.Add(this.AddPointBtn);
            this.Controls.Add(this.StudentsLabel);
            this.Controls.Add(this.StudentsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppTeacher";
            this.Text = "AppTeacher";
            this.Load += new System.EventHandler(this.AppTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.Button AddPointBtn;
        private System.Windows.Forms.Label StudIdLabel;
        private System.Windows.Forms.Label StudPointLabel;
        private System.Windows.Forms.NumericUpDown IdNUAD;
        private System.Windows.Forms.NumericUpDown PointNUAD;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox GroupsCB;
        private System.Windows.Forms.Label label1;
    }
}