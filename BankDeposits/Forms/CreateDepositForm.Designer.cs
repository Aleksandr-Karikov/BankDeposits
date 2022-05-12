namespace BankDeposits.Forms
{
    partial class CreateDepositForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._907b1_Karikov_ASDataSet = new BankDeposits._907b1_Karikov_ASDataSet();
            this.depositTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositTypesTableAdapter = new BankDeposits._907b1_Karikov_ASDataSetTableAdapters.DepositTypesTableAdapter();
            this.depositTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.Label();
            this.percents = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.srok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._907b1_Karikov_ASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.depositTypesBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип депозита";
            // 
            // _907b1_Karikov_ASDataSet
            // 
            this._907b1_Karikov_ASDataSet.DataSetName = "_907b1_Karikov_ASDataSet";
            this._907b1_Karikov_ASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositTypesBindingSource
            // 
            this.depositTypesBindingSource.DataMember = "DepositTypes";
            this.depositTypesBindingSource.DataSource = this._907b1_Karikov_ASDataSet;
            // 
            // depositTypesTableAdapter
            // 
            this.depositTypesTableAdapter.ClearBeforeFill = true;
            // 
            // depositTypesBindingSource1
            // 
            this.depositTypesBindingSource1.DataMember = "DepositTypes";
            this.depositTypesBindingSource1.DataSource = this._907b1_Karikov_ASDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Процент за";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "месяц:";
            // 
            // freq
            // 
            this.freq.AutoSize = true;
            this.freq.Location = new System.Drawing.Point(99, 155);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(13, 13);
            this.freq.TabIndex = 6;
            this.freq.Text = "1";
            // 
            // percents
            // 
            this.percents.AutoSize = true;
            this.percents.Location = new System.Drawing.Point(170, 155);
            this.percents.Name = "percents";
            this.percents.Size = new System.Drawing.Size(13, 13);
            this.percents.TabIndex = 7;
            this.percents.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Срок";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Подать заявку на открытие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Стартовая сумма";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(31, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Возможность пополнения";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(31, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(134, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Возможность снятия";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 239);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // srok
            // 
            this.srok.AutoSize = true;
            this.srok.Location = new System.Drawing.Point(77, 197);
            this.srok.Name = "srok";
            this.srok.Size = new System.Drawing.Size(35, 13);
            this.srok.TabIndex = 15;
            this.srok.Text = "label2";
            // 
            // CreateDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.srok);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.percents);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CreateDepositForm";
            this.Text = "CreateDepositForm";
            this.Load += new System.EventHandler(this.CreateDepositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._907b1_Karikov_ASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private _907b1_Karikov_ASDataSet _907b1_Karikov_ASDataSet;
        private System.Windows.Forms.BindingSource depositTypesBindingSource;
        private _907b1_Karikov_ASDataSetTableAdapters.DepositTypesTableAdapter depositTypesTableAdapter;
        private System.Windows.Forms.BindingSource depositTypesBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label freq;
        private System.Windows.Forms.Label percents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label srok;
    }
}