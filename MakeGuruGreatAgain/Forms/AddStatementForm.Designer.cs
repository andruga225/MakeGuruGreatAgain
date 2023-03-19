namespace MakeGuruGreatAgain.Forms
{
    partial class AddStatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStatementForm));
            this.TLPStatementMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TLPStatementVariable = new System.Windows.Forms.TableLayoutPanel();
            this.cbxStatementVariable = new System.Windows.Forms.ComboBox();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.lbEqual = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStatementValue = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStatementSave = new System.Windows.Forms.Button();
            this.btnStatementCancel = new System.Windows.Forms.Button();
            this.TLPStatementMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TLPStatementVariable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPStatementMain
            // 
            this.TLPStatementMain.ColumnCount = 1;
            this.TLPStatementMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPStatementMain.Controls.Add(this.groupBox1, 0, 0);
            this.TLPStatementMain.Controls.Add(this.lbEqual, 0, 1);
            this.TLPStatementMain.Controls.Add(this.groupBox2, 0, 2);
            this.TLPStatementMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.TLPStatementMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPStatementMain.Location = new System.Drawing.Point(0, 0);
            this.TLPStatementMain.Name = "TLPStatementMain";
            this.TLPStatementMain.RowCount = 4;
            this.TLPStatementMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLPStatementMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPStatementMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLPStatementMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPStatementMain.Size = new System.Drawing.Size(397, 171);
            this.TLPStatementMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TLPStatementVariable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable";
            // 
            // TLPStatementVariable
            // 
            this.TLPStatementVariable.ColumnCount = 2;
            this.TLPStatementVariable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.TLPStatementVariable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TLPStatementVariable.Controls.Add(this.cbxStatementVariable, 0, 0);
            this.TLPStatementVariable.Controls.Add(this.btnAddVariable, 1, 0);
            this.TLPStatementVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPStatementVariable.Location = new System.Drawing.Point(3, 19);
            this.TLPStatementVariable.Name = "TLPStatementVariable";
            this.TLPStatementVariable.RowCount = 1;
            this.TLPStatementVariable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPStatementVariable.Size = new System.Drawing.Size(385, 31);
            this.TLPStatementVariable.TabIndex = 1;
            // 
            // cbxStatementVariable
            // 
            this.cbxStatementVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatementVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatementVariable.FormattingEnabled = true;
            this.cbxStatementVariable.Location = new System.Drawing.Point(3, 3);
            this.cbxStatementVariable.Name = "cbxStatementVariable";
            this.cbxStatementVariable.Size = new System.Drawing.Size(332, 23);
            this.cbxStatementVariable.TabIndex = 0;
            this.cbxStatementVariable.SelectedIndexChanged += new System.EventHandler(this.cbxStatementVariable_SelectedIndexChanged);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVariable.BackgroundImage")));
            this.btnAddVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddVariable.Location = new System.Drawing.Point(341, 3);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(41, 23);
            this.btnAddVariable.TabIndex = 1;
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEqual.Location = new System.Drawing.Point(3, 59);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(391, 17);
            this.lbEqual.TabIndex = 1;
            this.lbEqual.Text = "=";
            this.lbEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStatementValue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Value";
            // 
            // cbxStatementValue
            // 
            this.cbxStatementValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatementValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatementValue.FormattingEnabled = true;
            this.cbxStatementValue.Location = new System.Drawing.Point(3, 19);
            this.cbxStatementValue.Name = "cbxStatementValue";
            this.cbxStatementValue.Size = new System.Drawing.Size(385, 23);
            this.cbxStatementValue.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnStatementSave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStatementCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnStatementSave
            // 
            this.btnStatementSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatementSave.Location = new System.Drawing.Point(3, 3);
            this.btnStatementSave.Name = "btnStatementSave";
            this.btnStatementSave.Size = new System.Drawing.Size(189, 24);
            this.btnStatementSave.TabIndex = 0;
            this.btnStatementSave.Text = "Save";
            this.btnStatementSave.UseVisualStyleBackColor = true;
            this.btnStatementSave.Click += new System.EventHandler(this.btnStatementSave_Click);
            // 
            // btnStatementCancel
            // 
            this.btnStatementCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatementCancel.Location = new System.Drawing.Point(198, 3);
            this.btnStatementCancel.Name = "btnStatementCancel";
            this.btnStatementCancel.Size = new System.Drawing.Size(190, 24);
            this.btnStatementCancel.TabIndex = 1;
            this.btnStatementCancel.Text = "Cancel";
            this.btnStatementCancel.UseVisualStyleBackColor = true;
            this.btnStatementCancel.Click += new System.EventHandler(this.btnStatementCancel_Click);
            // 
            // AddStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 171);
            this.Controls.Add(this.TLPStatementMain);
            this.Name = "AddStatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statement";
            this.TLPStatementMain.ResumeLayout(false);
            this.TLPStatementMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TLPStatementVariable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPStatementMain;
        private GroupBox groupBox1;
        private ComboBox cbxStatementVariable;
        private Label lbEqual;
        private GroupBox groupBox2;
        private ComboBox cbxStatementValue;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnStatementSave;
        private Button btnStatementCancel;
        private TableLayoutPanel TLPStatementVariable;
        private Button btnAddVariable;
    }
}