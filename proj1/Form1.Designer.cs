namespace proj1
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.TextBoxNumber1 = new System.Windows.Forms.TextBox();
            this.TextBoxNumber2 = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.Sinus = new System.Windows.Forms.Button();
            this.cosinus = new System.Windows.Forms.Button();
            this.Loge = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.powE = new System.Windows.Forms.Button();
            this.Inversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 64);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(93, 64);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 93);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(93, 93);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.ButtonClick);
            // 
            // TextBoxNumber1
            // 
            this.TextBoxNumber1.Location = new System.Drawing.Point(12, 12);
            this.TextBoxNumber1.Name = "TextBoxNumber1";
            this.TextBoxNumber1.Size = new System.Drawing.Size(155, 20);
            this.TextBoxNumber1.TabIndex = 4;
            // 
            // TextBoxNumber2
            // 
            this.TextBoxNumber2.Location = new System.Drawing.Point(12, 38);
            this.TextBoxNumber2.Name = "TextBoxNumber2";
            this.TextBoxNumber2.Size = new System.Drawing.Size(155, 20);
            this.TextBoxNumber2.TabIndex = 5;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(173, 12);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(156, 20);
            this.TextBoxResult.TabIndex = 6;
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(175, 63);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(75, 23);
            this.Sinus.TabIndex = 7;
            this.Sinus.Text = "Sin(a)";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.Button2Click);
            // 
            // cosinus
            // 
            this.cosinus.Location = new System.Drawing.Point(257, 63);
            this.cosinus.Name = "cosinus";
            this.cosinus.Size = new System.Drawing.Size(75, 23);
            this.cosinus.TabIndex = 8;
            this.cosinus.Text = "Cos(a)";
            this.cosinus.UseVisualStyleBackColor = true;
            this.cosinus.Click += new System.EventHandler(this.Button2Click);
            // 
            // Loge
            // 
            this.Loge.Location = new System.Drawing.Point(175, 93);
            this.Loge.Name = "Loge";
            this.Loge.Size = new System.Drawing.Size(75, 23);
            this.Loge.TabIndex = 9;
            this.Loge.Text = "Log e(a)";
            this.Loge.UseVisualStyleBackColor = true;
            this.Loge.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // powE
            // 
            this.powE.Location = new System.Drawing.Point(175, 36);
            this.powE.Name = "powE";
            this.powE.Size = new System.Drawing.Size(75, 23);
            this.powE.TabIndex = 11;
            this.powE.Text = "e^a";
            this.powE.UseVisualStyleBackColor = true;
            this.powE.Click += new System.EventHandler(this.Button2Click);
            // 
            // Inversion
            // 
            this.Inversion.Location = new System.Drawing.Point(257, 36);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(75, 23);
            this.Inversion.TabIndex = 12;
            this.Inversion.Text = "-a";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.Button2Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 128);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.powE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Loge);
            this.Controls.Add(this.cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.TextBoxNumber2);
            this.Controls.Add(this.TextBoxNumber1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox TextBoxNumber1;
        private System.Windows.Forms.TextBox TextBoxNumber2;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button cosinus;
        private System.Windows.Forms.Button Loge;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button powE;
        private System.Windows.Forms.Button Inversion;
    }
}

