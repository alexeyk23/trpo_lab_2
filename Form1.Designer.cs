namespace trpo_lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbxInpSeq = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txbxRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите последовательность";
            // 
            // txbxInpSeq
            // 
            this.txbxInpSeq.Location = new System.Drawing.Point(12, 25);
            this.txbxInpSeq.Name = "txbxInpSeq";
            this.txbxInpSeq.Size = new System.Drawing.Size(416, 20);
            this.txbxInpSeq.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(434, 25);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Посчитать";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txbxRes
            // 
            this.txbxRes.Location = new System.Drawing.Point(12, 109);
            this.txbxRes.Multiline = true;
            this.txbxRes.Name = "txbxRes";
            this.txbxRes.Size = new System.Drawing.Size(416, 64);
            this.txbxRes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результаты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbxRes);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txbxInpSeq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Подпоследовательность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxInpSeq;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txbxRes;
        private System.Windows.Forms.Label label2;
    }
}

