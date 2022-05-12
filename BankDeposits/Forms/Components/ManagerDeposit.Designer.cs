namespace BankDeposits.Forms.Components
{
    partial class ManagerDeposit
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeDep = new System.Windows.Forms.Label();
            this.StartBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeDep
            // 
            this.TypeDep.AutoSize = true;
            this.TypeDep.Location = new System.Drawing.Point(37, 9);
            this.TypeDep.Name = "TypeDep";
            this.TypeDep.Size = new System.Drawing.Size(35, 13);
            this.TypeDep.TabIndex = 0;
            this.TypeDep.Text = "label1";
            // 
            // StartBalance
            // 
            this.StartBalance.AutoSize = true;
            this.StartBalance.Location = new System.Drawing.Point(154, 35);
            this.StartBalance.Name = "StartBalance";
            this.StartBalance.Size = new System.Drawing.Size(35, 13);
            this.StartBalance.TabIndex = 1;
            this.StartBalance.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первоначальный вклад";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отклонить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBalance);
            this.Controls.Add(this.TypeDep);
            this.Name = "ManagerDeposit";
            this.Size = new System.Drawing.Size(299, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeDep;
        private System.Windows.Forms.Label StartBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
