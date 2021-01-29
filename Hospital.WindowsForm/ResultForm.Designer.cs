
namespace Hospital.WindowsForm
{
    partial class ResultForm
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblAllQuest = new System.Windows.Forms.Label();
            this.lblTrueQuest = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.Green;
            this.lblMain.Location = new System.Drawing.Point(130, 67);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(327, 50);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Тест пройдено!";
            // 
            // lblAllQuest
            // 
            this.lblAllQuest.AutoSize = true;
            this.lblAllQuest.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAllQuest.ForeColor = System.Drawing.Color.Green;
            this.lblAllQuest.Location = new System.Drawing.Point(103, 133);
            this.lblAllQuest.Name = "lblAllQuest";
            this.lblAllQuest.Size = new System.Drawing.Size(228, 31);
            this.lblAllQuest.TabIndex = 0;
            this.lblAllQuest.Text = "Всього запитань:";
            // 
            // lblTrueQuest
            // 
            this.lblTrueQuest.AutoSize = true;
            this.lblTrueQuest.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTrueQuest.ForeColor = System.Drawing.Color.Green;
            this.lblTrueQuest.Location = new System.Drawing.Point(103, 194);
            this.lblTrueQuest.Name = "lblTrueQuest";
            this.lblTrueQuest.Size = new System.Drawing.Size(296, 31);
            this.lblTrueQuest.TabIndex = 0;
            this.lblTrueQuest.Text = "Правильних відповідей:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(171, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 77);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Зберегти оцінку";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMark.ForeColor = System.Drawing.Color.Green;
            this.lblMark.Location = new System.Drawing.Point(103, 250);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(175, 31);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "Ваша оцінка:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Blue;
            this.lblDesc.Location = new System.Drawing.Point(103, 281);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(183, 20);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "(за 12-бальною шкалою)";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 413);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblTrueQuest);
            this.Controls.Add(this.lblAllQuest);
            this.Controls.Add(this.lblMain);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblAllQuest;
        private System.Windows.Forms.Label lblTrueQuest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblDesc;
    }
}