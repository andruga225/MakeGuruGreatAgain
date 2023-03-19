namespace MakeGuruGreatAgain.Forms
{
    partial class NewGoalForm
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
            this.TLPNewGoal = new System.Windows.Forms.TableLayoutPanel();
            this.TLPGoalButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxGoal = new System.Windows.Forms.ComboBox();
            this.TLPNewGoal.SuspendLayout();
            this.TLPGoalButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPNewGoal
            // 
            this.TLPNewGoal.ColumnCount = 1;
            this.TLPNewGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPNewGoal.Controls.Add(this.TLPGoalButtons, 0, 1);
            this.TLPNewGoal.Controls.Add(this.groupBox1, 0, 0);
            this.TLPNewGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPNewGoal.Location = new System.Drawing.Point(0, 0);
            this.TLPNewGoal.Name = "TLPNewGoal";
            this.TLPNewGoal.RowCount = 2;
            this.TLPNewGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.TLPNewGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.TLPNewGoal.Size = new System.Drawing.Size(299, 93);
            this.TLPNewGoal.TabIndex = 0;
            // 
            // TLPGoalButtons
            // 
            this.TLPGoalButtons.ColumnCount = 2;
            this.TLPGoalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPGoalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPGoalButtons.Controls.Add(this.btnOk, 0, 0);
            this.TLPGoalButtons.Controls.Add(this.btnCancel, 1, 0);
            this.TLPGoalButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPGoalButtons.Location = new System.Drawing.Point(3, 53);
            this.TLPGoalButtons.Name = "TLPGoalButtons";
            this.TLPGoalButtons.RowCount = 1;
            this.TLPGoalButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPGoalButtons.Size = new System.Drawing.Size(293, 37);
            this.TLPGoalButtons.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 31);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(149, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxGoal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultation goal";
            // 
            // cbxGoal
            // 
            this.cbxGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoal.FormattingEnabled = true;
            this.cbxGoal.Location = new System.Drawing.Point(3, 19);
            this.cbxGoal.Name = "cbxGoal";
            this.cbxGoal.Size = new System.Drawing.Size(287, 23);
            this.cbxGoal.TabIndex = 0;
            // 
            // NewGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 93);
            this.Controls.Add(this.TLPNewGoal);
            this.Name = "NewGoalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewGoalForm";
            this.TLPNewGoal.ResumeLayout(false);
            this.TLPGoalButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPNewGoal;
        private TableLayoutPanel TLPGoalButtons;
        private Button btnOk;
        private Button btnCancel;
        private GroupBox groupBox1;
        private ComboBox cbxGoal;
    }
}