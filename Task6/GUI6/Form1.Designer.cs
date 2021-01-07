namespace GUI6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.lenghtBox = new System.Windows.Forms.TextBox();
            this.uploadButt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.fromSailButt = new System.Windows.Forms.Button();
            this.toSailButt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(15, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lenght";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(15, 64);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 8;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(15, 103);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 9;
            // 
            // lenghtBox
            // 
            this.lenghtBox.Location = new System.Drawing.Point(15, 142);
            this.lenghtBox.Name = "lenghtBox";
            this.lenghtBox.Size = new System.Drawing.Size(100, 20);
            this.lenghtBox.TabIndex = 10;
            // 
            // uploadButt
            // 
            this.uploadButt.Location = new System.Drawing.Point(15, 194);
            this.uploadButt.Name = "uploadButt";
            this.uploadButt.Size = new System.Drawing.Size(100, 23);
            this.uploadButt.TabIndex = 11;
            this.uploadButt.Text = "Upload";
            this.uploadButt.UseVisualStyleBackColor = true;
            this.uploadButt.Click += new System.EventHandler(this.uploadButt_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(121, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 160);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(244, 25);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(117, 219);
            this.outBox.TabIndex = 13;
            // 
            // fromSailButt
            // 
            this.fromSailButt.Location = new System.Drawing.Point(244, 262);
            this.fromSailButt.Name = "fromSailButt";
            this.fromSailButt.Size = new System.Drawing.Size(100, 23);
            this.fromSailButt.TabIndex = 14;
            this.fromSailButt.Text = "Вернись!";
            this.fromSailButt.UseVisualStyleBackColor = true;
            this.fromSailButt.Click += new System.EventHandler(this.fromSailButt_Click);
            // 
            // toSailButt
            // 
            this.toSailButt.Location = new System.Drawing.Point(121, 194);
            this.toSailButt.Name = "toSailButt";
            this.toSailButt.Size = new System.Drawing.Size(100, 23);
            this.toSailButt.TabIndex = 15;
            this.toSailButt.Text = "В плавание";
            this.toSailButt.UseVisualStyleBackColor = true;
            this.toSailButt.Click += new System.EventHandler(this.toSailButt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toSailButt);
            this.Controls.Add(this.fromSailButt);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uploadButt);
            this.Controls.Add(this.lenghtBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox lenghtBox;
        private System.Windows.Forms.Button uploadButt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Button fromSailButt;
        private System.Windows.Forms.Button toSailButt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

