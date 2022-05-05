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
            this.FioLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 56);
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
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.Location = new System.Drawing.Point(51, 118);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(0, 13);
            this.FioLabel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Открыть вклад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(51, 244);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(340, 21);
            this.TypeComboBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Посмотреть информацию по вкладам";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(534, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button button2;
    }
}
