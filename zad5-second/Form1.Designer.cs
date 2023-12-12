namespace zad5_second
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
            this.components = new System.ComponentModel.Container();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMinutes
            // 
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinutes.Location = new System.Drawing.Point(32, 65);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(66, 20);
            this.txtMinutes.TabIndex = 0;
            // 
            // txtSeconds
            // 
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeconds.Location = new System.Drawing.Point(198, 65);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(66, 20);
            this.txtSeconds.TabIndex = 1;
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(198, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Menu;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Location = new System.Drawing.Point(279, 68);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(67, 13);
            this.txt2.TabIndex = 3;
            this.txt2.Text = "сек.";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Menu;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Location = new System.Drawing.Point(113, 68);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(67, 13);
            this.txt1.TabIndex = 4;
            this.txt1.Text = "мин.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 196);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

