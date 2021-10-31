
namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.Label();
            this.WinsNum = new System.Windows.Forms.Label();
            this.LivesNum = new System.Windows.Forms.Label();
            this.AnswerStatus = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(118, 99);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 0;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, -67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(12, 100);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 23);
            this.Answer.TabIndex = 2;
            this.Answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerKeyDown);
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Location = new System.Drawing.Point(12, 9);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(38, 15);
            this.Condition.TabIndex = 3;
            this.Condition.Text = "label5";
            // 
            // WinsNum
            // 
            this.WinsNum.AutoSize = true;
            this.WinsNum.Location = new System.Drawing.Point(12, 41);
            this.WinsNum.Name = "WinsNum";
            this.WinsNum.Size = new System.Drawing.Size(38, 15);
            this.WinsNum.TabIndex = 4;
            this.WinsNum.Text = "label3";
            // 
            // LivesNum
            // 
            this.LivesNum.AutoSize = true;
            this.LivesNum.Location = new System.Drawing.Point(13, 69);
            this.LivesNum.Name = "LivesNum";
            this.LivesNum.Size = new System.Drawing.Size(38, 15);
            this.LivesNum.TabIndex = 5;
            this.LivesNum.Text = "label4";
            // 
            // AnswerStatus
            // 
            this.AnswerStatus.AutoSize = true;
            this.AnswerStatus.Location = new System.Drawing.Point(210, 103);
            this.AnswerStatus.Name = "AnswerStatus";
            this.AnswerStatus.Size = new System.Drawing.Size(0, 15);
            this.AnswerStatus.TabIndex = 6;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(12, 162);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(100, 23);
            this.Restart.TabIndex = 7;
            this.Restart.Text = "Перезапустить";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.AnswerStatus);
            this.Controls.Add(this.LivesNum);
            this.Controls.Add(this.WinsNum);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label WinsNum;
        private System.Windows.Forms.Label LivesNum;
        private System.Windows.Forms.Label AnswerStatus;
        private System.Windows.Forms.Button Restart;
    }
}