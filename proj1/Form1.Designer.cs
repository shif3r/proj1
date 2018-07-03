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
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.TextBoxNum1 = new System.Windows.Forms.TextBox();
            this.TextBoxNum2 = new System.Windows.Forms.TextBox();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(12, 64);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 0;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(93, 64);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 23);
            this.ButtonMinus.TabIndex = 1;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(12, 93);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(75, 23);
            this.ButtonMultiply.TabIndex = 2;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(93, 93);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(75, 23);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // TextBoxNum1
            // 
            this.TextBoxNum1.Location = new System.Drawing.Point(12, 12);
            this.TextBoxNum1.Name = "TextBoxNum1";
            this.TextBoxNum1.Size = new System.Drawing.Size(155, 20);
            this.TextBoxNum1.TabIndex = 4;
            // 
            // TextBoxNum2
            // 
            this.TextBoxNum2.Location = new System.Drawing.Point(12, 38);
            this.TextBoxNum2.Name = "TextBoxNum2";
            this.TextBoxNum2.Size = new System.Drawing.Size(155, 20);
            this.TextBoxNum2.TabIndex = 5;
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
            this.Controls.Add(this.TextBoxNum2);
            this.Controls.Add(this.TextBoxNum1);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.TextBox TextBoxNum1;
        private System.Windows.Forms.TextBox TextBoxNum2;
        private System.Windows.Forms.TextBox TextBoxResult;
    }
}

