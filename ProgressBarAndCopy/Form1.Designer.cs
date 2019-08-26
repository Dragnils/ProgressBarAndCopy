namespace ProgressBarAndCopy
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
            this.btnFile1 = new System.Windows.Forms.Button();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourse = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(660, 58);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(75, 23);
            this.btnFile1.TabIndex = 0;
            this.btnFile1.Text = "Файл...";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(660, 111);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(75, 23);
            this.btnFile2.TabIndex = 1;
            this.btnFile2.Text = "Файл...";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "От куда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Куда";
            // 
            // txtSourse
            // 
            this.txtSourse.Location = new System.Drawing.Point(164, 60);
            this.txtSourse.Name = "txtSourse";
            this.txtSourse.Size = new System.Drawing.Size(471, 20);
            this.txtSourse.TabIndex = 4;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(164, 113);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(471, 20);
            this.txtDestination.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(660, 158);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0%";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.btnFile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.Button btnFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourse;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

