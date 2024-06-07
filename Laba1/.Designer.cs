namespace Laba1
{
    partial class Initial_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.nochoose = new System.Windows.Forms.Label();
            this.nochoose1 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 31;
            this.listBox.Location = new System.Drawing.Point(46, 60);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1118, 376);
            this.listBox.TabIndex = 0;
            this.listBox.Click += new System.EventHandler(this.listbox_Click);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(342, 471);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(491, 101);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать новую запись";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(342, 596);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(491, 103);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить выбранную запись";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(342, 733);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(491, 98);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить выбранную запись";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // nochoose
            // 
            this.nochoose.AutoSize = true;
            this.nochoose.Location = new System.Drawing.Point(293, 698);
            this.nochoose.Name = "nochoose";
            this.nochoose.Size = new System.Drawing.Size(21, 32);
            this.nochoose.TabIndex = 5;
            this.nochoose.Text = " \r\n";
            // 
            // nochoose1
            // 
            this.nochoose1.AutoSize = true;
            this.nochoose1.Location = new System.Drawing.Point(293, 830);
            this.nochoose1.Name = "nochoose1";
            this.nochoose1.Size = new System.Drawing.Size(21, 32);
            this.nochoose1.TabIndex = 6;
            this.nochoose1.Text = " \r\n";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(69, 555);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(195, 85);
            this.Sort.TabIndex = 7;
            this.Sort.Text = "Sort (вкл/выкл)\r\n\r\n\r\n\r\n\r\n";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(863, 555);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(356, 36);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Включить фильтрацию";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(115, 643);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(0, 32);
            this.Sort_label.TabIndex = 9;
            // 
            // Initial_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 871);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.nochoose1);
            this.Controls.Add(this.nochoose);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.listBox);
            this.Name = "Initial_form";
            this.Text = "Начальное окно";
            this.Load += new System.EventHandler(this.initial_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label nochoose;
        private System.Windows.Forms.Label nochoose1;
        private System.Windows.Forms.Button Sort;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label Sort_label;
    }
}

