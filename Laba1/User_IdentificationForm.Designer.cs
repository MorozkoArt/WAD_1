namespace Laba1
{
    partial class User_IdentificationForm
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
            this.admin_user = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label_Iden = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_user
            // 
            this.admin_user.FormattingEnabled = true;
            this.admin_user.Location = new System.Drawing.Point(387, 227);
            this.admin_user.Name = "admin_user";
            this.admin_user.Size = new System.Drawing.Size(286, 39);
            this.admin_user.TabIndex = 0;
            this.admin_user.SelectedIndexChanged += new System.EventHandler(this.admin_user_SelectedIndexChanged);
            this.admin_user.Click += new System.EventHandler(this.Admin_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(387, 329);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(286, 38);
            this.password.TabIndex = 1;
            this.password.Click += new System.EventHandler(this.Password_Click);
            // 
            // label_Iden
            // 
            this.label_Iden.AutoSize = true;
            this.label_Iden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Iden.Location = new System.Drawing.Point(265, 38);
            this.label_Iden.Name = "label_Iden";
            this.label_Iden.Size = new System.Drawing.Size(482, 69);
            this.label_Iden.TabIndex = 12;
            this.label_Iden.Text = "Идентификация";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(219, 447);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(161, 59);
            this.OK.TabIndex = 13;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 59);
            this.button2.TabIndex = 14;
            this.button2.Text = "Chanel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Location = new System.Drawing.Point(689, 335);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(0, 32);
            this.Incorrect.TabIndex = 16;
            // 
            // User_IdentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 615);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label_Iden);
            this.Controls.Add(this.password);
            this.Controls.Add(this.admin_user);
            this.KeyPreview = true;
            this.Name = "User_IdentificationForm";
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.User_IdentificationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox admin_user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label_Iden;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Incorrect;
    }
}