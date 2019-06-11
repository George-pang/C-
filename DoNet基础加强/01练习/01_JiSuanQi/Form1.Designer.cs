namespace _01_JiSuanQi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.cmbCaoZuoFu = new System.Windows.Forms.ComboBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.labelResut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(42, 42);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(115, 25);
            this.textNum1.TabIndex = 0;
            this.textNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCaoZuoFu
            // 
            this.cmbCaoZuoFu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaoZuoFu.FormattingEnabled = true;
            this.cmbCaoZuoFu.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbCaoZuoFu.Location = new System.Drawing.Point(163, 42);
            this.cmbCaoZuoFu.Name = "cmbCaoZuoFu";
            this.cmbCaoZuoFu.Size = new System.Drawing.Size(121, 23);
            this.cmbCaoZuoFu.TabIndex = 1;
            this.cmbCaoZuoFu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(290, 40);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 25);
            this.textNum2.TabIndex = 2;
            this.textNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(409, 43);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResut
            // 
            this.labelResut.AutoSize = true;
            this.labelResut.Location = new System.Drawing.Point(524, 51);
            this.labelResut.Name = "labelResut";
            this.labelResut.Size = new System.Drawing.Size(55, 15);
            this.labelResut.TabIndex = 4;
            this.labelResut.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 282);
            this.Controls.Add(this.labelResut);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.cmbCaoZuoFu);
            this.Controls.Add(this.textNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.ComboBox cmbCaoZuoFu;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label labelResut;
    }
}

