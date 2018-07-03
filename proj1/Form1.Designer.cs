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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 128);
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
    }
}

