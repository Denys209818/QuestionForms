
namespace Hospital.WindowsForm
{
    partial class QuestionForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.Color.Blue;
            this.lblQuestion.Location = new System.Drawing.Point(26, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(114, 28);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Запитання";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Location = new System.Drawing.Point(26, 105);
            this.gbAnswers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAnswers.Size = new System.Drawing.Size(599, 221);
            this.gbAnswers.TabIndex = 2;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Варіанти відповіді";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(514, 369);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 47);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Далі >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 369);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<< Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(214, 370);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(203, 35);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Питання: 1-10";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 447);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пройти тест";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCount;
    }
}