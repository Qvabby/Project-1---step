namespace Project_1___step
{
    partial class Register
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
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.UsernameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.RoleL = new System.Windows.Forms.Label();
            this.AdministratorRB = new System.Windows.Forms.RadioButton();
            this.TeacherRB = new System.Windows.Forms.RadioButton();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTb
            // 
            this.UsernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTb.Location = new System.Drawing.Point(16, 32);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(185, 26);
            this.UsernameTb.TabIndex = 0;
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameL.Location = new System.Drawing.Point(12, 9);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(83, 20);
            this.UsernameL.TabIndex = 1;
            this.UsernameL.Text = "Username";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(12, 69);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(78, 20);
            this.PasswordL.TabIndex = 3;
            this.PasswordL.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(16, 92);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(185, 26);
            this.PasswordTb.TabIndex = 2;
            // 
            // RoleL
            // 
            this.RoleL.AutoSize = true;
            this.RoleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleL.Location = new System.Drawing.Point(12, 130);
            this.RoleL.Name = "RoleL";
            this.RoleL.Size = new System.Drawing.Size(42, 20);
            this.RoleL.TabIndex = 5;
            this.RoleL.Text = "Role";
            // 
            // AdministratorRB
            // 
            this.AdministratorRB.AutoSize = true;
            this.AdministratorRB.Location = new System.Drawing.Point(16, 153);
            this.AdministratorRB.Name = "AdministratorRB";
            this.AdministratorRB.Size = new System.Drawing.Size(85, 17);
            this.AdministratorRB.TabIndex = 6;
            this.AdministratorRB.TabStop = true;
            this.AdministratorRB.Text = "Administrator";
            this.AdministratorRB.UseVisualStyleBackColor = true;
            // 
            // TeacherRB
            // 
            this.TeacherRB.AutoSize = true;
            this.TeacherRB.Location = new System.Drawing.Point(107, 153);
            this.TeacherRB.Name = "TeacherRB";
            this.TeacherRB.Size = new System.Drawing.Size(65, 17);
            this.TeacherRB.TabIndex = 7;
            this.TeacherRB.TabStop = true;
            this.TeacherRB.Text = "Teacher";
            this.TeacherRB.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(15, 188);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(86, 33);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 235);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.TeacherRB);
            this.Controls.Add(this.AdministratorRB);
            this.Controls.Add(this.RoleL);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UsernameL);
            this.Controls.Add(this.UsernameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Label UsernameL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label RoleL;
        private System.Windows.Forms.RadioButton AdministratorRB;
        private System.Windows.Forms.RadioButton TeacherRB;
        private System.Windows.Forms.Button RegisterBtn;
    }
}