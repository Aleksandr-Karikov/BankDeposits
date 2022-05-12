namespace BankDeposits.Forms.Components
{
    partial class MainControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.balalnce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(190, 65);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 13);
            this.balanceLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Открыть вклад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(36, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 354);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Информация по вашим вкладам";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(54, 18);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(0, 25);
            this.fio.TabIndex = 8;
            // 
            // balalnce
            // 
            this.balalnce.AutoSize = true;
            this.balalnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balalnce.Location = new System.Drawing.Point(139, 48);
            this.balalnce.Name = "balalnce";
            this.balalnce.Size = new System.Drawing.Size(70, 25);
            this.balalnce.TabIndex = 9;
            this.balalnce.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Общий доход с вкладов";
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profit.Location = new System.Drawing.Point(318, 97);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(70, 25);
            this.Profit.TabIndex = 11;
            this.Profit.Text = "label3";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balalnce);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(534, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label balalnce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Profit;
    }
}
