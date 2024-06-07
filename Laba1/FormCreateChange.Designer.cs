namespace Laba1
{
    partial class FormCreateChange
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
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Birthday1 = new System.Windows.Forms.DateTimePicker();
            this.CardName1 = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.cancellation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoCardName = new System.Windows.Forms.Label();
            this.NoName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(418, 209);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(368, 38);
            this.Name1.TabIndex = 0;
            this.Name1.Click += new System.EventHandler(this.Name_Click);
            // 
            // Birthday1
            // 
            this.Birthday1.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.Birthday1.Location = new System.Drawing.Point(418, 309);
            this.Birthday1.Name = "Birthday1";
            this.Birthday1.Size = new System.Drawing.Size(368, 38);
            this.Birthday1.TabIndex = 1;
            this.Birthday1.Value = new System.DateTime(2023, 10, 4, 0, 0, 0, 0);
            // 
            // CardName1
            // 
            this.CardName1.Location = new System.Drawing.Point(418, 405);
            this.CardName1.MaxLength = 5;
            this.CardName1.Name = "CardName1";
            this.CardName1.Size = new System.Drawing.Size(368, 38);
            this.CardName1.TabIndex = 2;
            this.CardName1.Click += new System.EventHandler(this.CardName1_Click);
            this.CardName1.TextChanged += new System.EventHandler(this.CardName1_TextChanged);
            this.CardName1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardName1_KeyPress);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(229, 551);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(183, 60);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            this.Accept.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Accept_MouseMove);
            // 
            // cancellation
            // 
            this.cancellation.Location = new System.Drawing.Point(789, 551);
            this.cancellation.Name = "cancellation";
            this.cancellation.Size = new System.Drawing.Size(177, 60);
            this.cancellation.TabIndex = 5;
            this.cancellation.Text = "Отменить";
            this.cancellation.UseVisualStyleBackColor = true;
            this.cancellation.Click += new System.EventHandler(this.Cancellation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата рождения";
            // 
            // NoCardName
            // 
            this.NoCardName.AutoSize = true;
            this.NoCardName.Location = new System.Drawing.Point(412, 466);
            this.NoCardName.Name = "NoCardName";
            this.NoCardName.Size = new System.Drawing.Size(21, 64);
            this.NoCardName.TabIndex = 9;
            this.NoCardName.Text = " \r\n\r\n";
            // 
            // NoName
            // 
            this.NoName.AutoSize = true;
            this.NoName.Location = new System.Drawing.Point(792, 209);
            this.NoName.Name = "NoName";
            this.NoName.Size = new System.Drawing.Size(0, 32);
            this.NoName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(158, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(627, 61);
            this.label4.TabIndex = 11;
            this.label4.Text = "Создание записизаписи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер карты";
            // 
            // FormCreateChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 750);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoName);
            this.Controls.Add(this.NoCardName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancellation);
            this.Controls.Add(this.CardName1);
            this.Controls.Add(this.Birthday1);
            this.Controls.Add(this.Name1);
            this.KeyPreview = true;
            this.Name = "FormCreateChange";
            this.Text = "FormCreateChange";
            this.Activated += new System.EventHandler(this.FormCreateChange_Activated);
            this.Load += new System.EventHandler(this.FormCreateChange_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCreateChange_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.DateTimePicker Birthday1;
        private System.Windows.Forms.TextBox CardName1;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button cancellation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NoCardName;
        private System.Windows.Forms.Label NoName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}