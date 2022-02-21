
namespace PSB_Task1
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
            this.GetInfo_button = new System.Windows.Forms.Button();
            this.ProcessNames_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GetInfo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.GetInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetInfo_button.ForeColor = System.Drawing.Color.White;
            this.GetInfo_button.Location = new System.Drawing.Point(144, 166);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(75, 23);
            this.GetInfo_button.TabIndex = 0;
            this.GetInfo_button.Text = "Get info";
            this.GetInfo_button.UseVisualStyleBackColor = false;
            this.GetInfo_button.Click += new System.EventHandler(this.GetInfo_button_Click);
            // 
            // ProcessNames_textBox
            // 
            this.ProcessNames_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessNames_textBox.BackColor = System.Drawing.Color.DimGray;
            this.ProcessNames_textBox.ForeColor = System.Drawing.Color.White;
            this.ProcessNames_textBox.Location = new System.Drawing.Point(32, 60);
            this.ProcessNames_textBox.Name = "ProcessNames_textBox";
            this.ProcessNames_textBox.Size = new System.Drawing.Size(306, 20);
            this.ProcessNames_textBox.TabIndex = 1;
            this.ProcessNames_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessNames_textBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter process name(s):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(379, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessNames_textBox);
            this.Controls.Add(this.GetInfo_button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.Name = "Form1";
            this.Text = "ProcessInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.TextBox ProcessNames_textBox;
        private System.Windows.Forms.Label label1;
    }
}

