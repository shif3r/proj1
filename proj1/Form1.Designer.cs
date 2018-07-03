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
            this.Logarifm2 = new System.Windows.Forms.Button();
            this.powE = new System.Windows.Forms.Button();
            this.Inversion = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Minimum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Maximum = new System.Windows.Forms.Button();
            this.LogBofA = new System.Windows.Forms.Button();
            this.Remainder = new System.Windows.Forms.Button();
            this.BRootOfA = new System.Windows.Forms.Button();
            this.Logarifm10 = new System.Windows.Forms.Button();
            this.Pow2 = new System.Windows.Forms.Button();
            this.ArcSinus = new System.Windows.Forms.Button();
            this.ArcCosinus = new System.Windows.Forms.Button();
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
            // Logarifm2
            // 
            this.Logarifm2.Location = new System.Drawing.Point(257, 93);
            this.Logarifm2.Name = "Logarifm2";
            this.Logarifm2.Size = new System.Drawing.Size(75, 23);
            this.Logarifm2.TabIndex = 10;
            this.Logarifm2.Text = "Log2(a)";
            this.Logarifm2.UseVisualStyleBackColor = true;
            this.Logarifm2.Click += new System.EventHandler(this.Button2Click);
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
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(12, 122);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(75, 23);
            this.Power.TabIndex = 3;
            this.Power.Text = "a^b";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(93, 122);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(75, 23);
            this.Minimum.TabIndex = 3;
            this.Minimum.Text = "Min";
            this.Minimum.UseVisualStyleBackColor = true;
            this.Minimum.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(93, 151);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(75, 23);
            this.Maximum.TabIndex = 3;
            this.Maximum.Text = "Max";
            this.Maximum.UseVisualStyleBackColor = true;
            this.Maximum.Click += new System.EventHandler(this.ButtonClick);
            // 
            // LogBofA
            // 
            this.LogBofA.Location = new System.Drawing.Point(12, 151);
            this.LogBofA.Name = "LogBofA";
            this.LogBofA.Size = new System.Drawing.Size(75, 23);
            this.LogBofA.TabIndex = 3;
            this.LogBofA.Text = "LogB(A)";
            this.LogBofA.UseVisualStyleBackColor = true;
            this.LogBofA.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Remainder
            // 
            this.Remainder.Location = new System.Drawing.Point(12, 180);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(75, 23);
            this.Remainder.TabIndex = 3;
            this.Remainder.Text = "a%b";
            this.Remainder.UseVisualStyleBackColor = true;
            this.Remainder.Click += new System.EventHandler(this.ButtonClick);
            // 
            // BRootOfA
            // 
            this.BRootOfA.Location = new System.Drawing.Point(93, 180);
            this.BRootOfA.Name = "BRootOfA";
            this.BRootOfA.Size = new System.Drawing.Size(75, 23);
            this.BRootOfA.TabIndex = 3;
            this.BRootOfA.Text = "a^1/b";
            this.BRootOfA.UseVisualStyleBackColor = true;
            this.BRootOfA.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Logarifm10
            // 
            this.Logarifm10.Location = new System.Drawing.Point(175, 122);
            this.Logarifm10.Name = "Logarifm10";
            this.Logarifm10.Size = new System.Drawing.Size(75, 23);
            this.Logarifm10.TabIndex = 13;
            this.Logarifm10.Text = "Log10(a)";
            this.Logarifm10.UseVisualStyleBackColor = true;
            this.Logarifm10.Click += new System.EventHandler(this.Button2Click);
            // 
            // Pow2
            // 
            this.Pow2.Location = new System.Drawing.Point(256, 122);
            this.Pow2.Name = "Pow2";
            this.Pow2.Size = new System.Drawing.Size(75, 23);
            this.Pow2.TabIndex = 14;
            this.Pow2.Text = "x^2";
            this.Pow2.UseVisualStyleBackColor = true;
            this.Pow2.Click += new System.EventHandler(this.Button2Click);
            // 
            // ArcSinus
            // 
            this.ArcSinus.Location = new System.Drawing.Point(175, 151);
            this.ArcSinus.Name = "ArcSinus";
            this.ArcSinus.Size = new System.Drawing.Size(75, 23);
            this.ArcSinus.TabIndex = 15;
            this.ArcSinus.Text = "ArcSin(a)";
            this.ArcSinus.UseVisualStyleBackColor = true;
            this.ArcSinus.Click += new System.EventHandler(this.Button2Click);
            // 
            // ArcCosinus
            // 
            this.ArcCosinus.Location = new System.Drawing.Point(257, 151);
            this.ArcCosinus.Name = "ArcCosinus";
            this.ArcCosinus.Size = new System.Drawing.Size(75, 23);
            this.ArcCosinus.TabIndex = 16;
            this.ArcCosinus.Text = "ArcCos(a)";
            this.ArcCosinus.UseVisualStyleBackColor = true;
            this.ArcCosinus.Click += new System.EventHandler(this.Button2Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 213);
            this.Controls.Add(this.ArcCosinus);
            this.Controls.Add(this.ArcSinus);
            this.Controls.Add(this.Pow2);
            this.Controls.Add(this.Logarifm10);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.powE);
            this.Controls.Add(this.Logarifm2);
            this.Controls.Add(this.Loge);
            this.Controls.Add(this.cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.TextBoxNumber2);
            this.Controls.Add(this.TextBoxNumber1);
            this.Controls.Add(this.BRootOfA);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.LogBofA);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.Power);
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
        private System.Windows.Forms.Button Logarifm2;
        private System.Windows.Forms.Button powE;
        private System.Windows.Forms.Button Inversion;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Minimum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Maximum;
        private System.Windows.Forms.Button LogBofA;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button BRootOfA;
        private System.Windows.Forms.Button Logarifm10;
        private System.Windows.Forms.Button Pow2;
        private System.Windows.Forms.Button ArcSinus;
        private System.Windows.Forms.Button ArcCosinus;
    }
}

