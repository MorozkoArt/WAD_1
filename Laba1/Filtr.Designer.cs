namespace Laba1
{
    partial class Filtr
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
            this.inTextForFiltr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inTextForFiltr
            // 
            this.inTextForFiltr.Location = new System.Drawing.Point(29, 68);
            this.inTextForFiltr.Name = "inTextForFiltr";
            this.inTextForFiltr.Size = new System.Drawing.Size(712, 38);
            this.inTextForFiltr.TabIndex = 0;
            this.inTextForFiltr.TextChanged += new System.EventHandler(this.inTextForFiltr_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отменить фильтрацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inTextForFiltr);
            this.Location = new System.Drawing.Point(700, 50);
            this.Name = "Filtr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Filter_Closed);
            this.Load += new System.EventHandler(this.Filtr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inTextForFiltr;
        private System.Windows.Forms.Button button1;
    }
}