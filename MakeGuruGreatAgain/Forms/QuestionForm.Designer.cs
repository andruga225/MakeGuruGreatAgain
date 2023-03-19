namespace MakeGuruGreatAgain.Forms
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
            this.TLPQuestionForm = new System.Windows.Forms.TableLayoutPanel();
            this.cbxVariableValue = new System.Windows.Forms.ComboBox();
            this.lbVariableQuestion = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.TLPQuestionForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPQuestionForm
            // 
            this.TLPQuestionForm.ColumnCount = 1;
            this.TLPQuestionForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPQuestionForm.Controls.Add(this.cbxVariableValue, 0, 1);
            this.TLPQuestionForm.Controls.Add(this.lbVariableQuestion, 0, 0);
            this.TLPQuestionForm.Controls.Add(this.btnAnswer, 0, 2);
            this.TLPQuestionForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPQuestionForm.Location = new System.Drawing.Point(0, 0);
            this.TLPQuestionForm.Name = "TLPQuestionForm";
            this.TLPQuestionForm.RowCount = 3;
            this.TLPQuestionForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPQuestionForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLPQuestionForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLPQuestionForm.Size = new System.Drawing.Size(328, 86);
            this.TLPQuestionForm.TabIndex = 0;
            // 
            // cbxVariableValue
            // 
            this.cbxVariableValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxVariableValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVariableValue.FormattingEnabled = true;
            this.cbxVariableValue.Location = new System.Drawing.Point(3, 28);
            this.cbxVariableValue.Name = "cbxVariableValue";
            this.cbxVariableValue.Size = new System.Drawing.Size(322, 23);
            this.cbxVariableValue.TabIndex = 0;
            // 
            // lbVariableQuestion
            // 
            this.lbVariableQuestion.AutoSize = true;
            this.lbVariableQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVariableQuestion.Location = new System.Drawing.Point(3, 0);
            this.lbVariableQuestion.Name = "lbVariableQuestion";
            this.lbVariableQuestion.Size = new System.Drawing.Size(322, 25);
            this.lbVariableQuestion.TabIndex = 1;
            this.lbVariableQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnswer.Location = new System.Drawing.Point(3, 58);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(322, 25);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 86);
            this.Controls.Add(this.TLPQuestionForm);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionForm";
            this.TLPQuestionForm.ResumeLayout(false);
            this.TLPQuestionForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPQuestionForm;
        private ComboBox cbxVariableValue;
        private Label lbVariableQuestion;
        private Button btnAnswer;
    }
}