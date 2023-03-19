namespace MakeGuruGreatAgain.Forms
{
    partial class AddVariableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVariableForm));
            this.TLPVariableAll = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVariableName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TLPVariableDomain = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.cbVariableDomain = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TLPVariableType = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnRequested = new System.Windows.Forms.RadioButton();
            this.rbtnOutput = new System.Windows.Forms.RadioButton();
            this.rbtnReqOut = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.TLPVariableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnVariableOk = new System.Windows.Forms.Button();
            this.btnVariableCancel = new System.Windows.Forms.Button();
            this.TLPVariableAll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TLPVariableDomain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TLPVariableType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TLPVariableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPVariableAll
            // 
            this.TLPVariableAll.ColumnCount = 1;
            this.TLPVariableAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPVariableAll.Controls.Add(this.groupBox1, 0, 0);
            this.TLPVariableAll.Controls.Add(this.groupBox2, 0, 1);
            this.TLPVariableAll.Controls.Add(this.groupBox3, 0, 2);
            this.TLPVariableAll.Controls.Add(this.groupBox4, 0, 3);
            this.TLPVariableAll.Controls.Add(this.TLPVariableButtons, 0, 4);
            this.TLPVariableAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPVariableAll.Location = new System.Drawing.Point(0, 0);
            this.TLPVariableAll.Name = "TLPVariableAll";
            this.TLPVariableAll.RowCount = 5;
            this.TLPVariableAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPVariableAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPVariableAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TLPVariableAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPVariableAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPVariableAll.Size = new System.Drawing.Size(466, 405);
            this.TLPVariableAll.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVariableName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable name";
            // 
            // tbVariableName
            // 
            this.tbVariableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVariableName.Location = new System.Drawing.Point(3, 19);
            this.tbVariableName.Name = "tbVariableName";
            this.tbVariableName.Size = new System.Drawing.Size(454, 23);
            this.tbVariableName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TLPVariableDomain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variable domain";
            // 
            // TLPVariableDomain
            // 
            this.TLPVariableDomain.ColumnCount = 2;
            this.TLPVariableDomain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.54626F));
            this.TLPVariableDomain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.45374F));
            this.TLPVariableDomain.Controls.Add(this.btnAddDomain, 1, 0);
            this.TLPVariableDomain.Controls.Add(this.cbVariableDomain, 0, 0);
            this.TLPVariableDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPVariableDomain.Location = new System.Drawing.Point(3, 19);
            this.TLPVariableDomain.Name = "TLPVariableDomain";
            this.TLPVariableDomain.RowCount = 1;
            this.TLPVariableDomain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPVariableDomain.Size = new System.Drawing.Size(454, 32);
            this.TLPVariableDomain.TabIndex = 0;
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDomain.BackgroundImage")));
            this.btnAddDomain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDomain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDomain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddDomain.Location = new System.Drawing.Point(405, 3);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(46, 26);
            this.btnAddDomain.TabIndex = 0;
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // cbVariableDomain
            // 
            this.cbVariableDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVariableDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariableDomain.FormattingEnabled = true;
            this.cbVariableDomain.Location = new System.Drawing.Point(3, 3);
            this.cbVariableDomain.Name = "cbVariableDomain";
            this.cbVariableDomain.Size = new System.Drawing.Size(396, 23);
            this.cbVariableDomain.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TLPVariableType);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variable type";
            // 
            // TLPVariableType
            // 
            this.TLPVariableType.ColumnCount = 1;
            this.TLPVariableType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPVariableType.Controls.Add(this.rbtnRequested, 0, 0);
            this.TLPVariableType.Controls.Add(this.rbtnOutput, 0, 1);
            this.TLPVariableType.Controls.Add(this.rbtnReqOut, 0, 2);
            this.TLPVariableType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPVariableType.Location = new System.Drawing.Point(3, 19);
            this.TLPVariableType.Name = "TLPVariableType";
            this.TLPVariableType.RowCount = 3;
            this.TLPVariableType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPVariableType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPVariableType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPVariableType.Size = new System.Drawing.Size(454, 154);
            this.TLPVariableType.TabIndex = 0;
            // 
            // rbtnRequested
            // 
            this.rbtnRequested.AutoSize = true;
            this.rbtnRequested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnRequested.Location = new System.Drawing.Point(3, 3);
            this.rbtnRequested.Name = "rbtnRequested";
            this.rbtnRequested.Size = new System.Drawing.Size(448, 45);
            this.rbtnRequested.TabIndex = 0;
            this.rbtnRequested.TabStop = true;
            this.rbtnRequested.Text = "Requested";
            this.rbtnRequested.UseVisualStyleBackColor = true;
            this.rbtnRequested.CheckedChanged += new System.EventHandler(this.variableTypeChanged);
            // 
            // rbtnOutput
            // 
            this.rbtnOutput.AutoSize = true;
            this.rbtnOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnOutput.Location = new System.Drawing.Point(3, 54);
            this.rbtnOutput.Name = "rbtnOutput";
            this.rbtnOutput.Size = new System.Drawing.Size(448, 45);
            this.rbtnOutput.TabIndex = 1;
            this.rbtnOutput.TabStop = true;
            this.rbtnOutput.Text = "Output";
            this.rbtnOutput.UseVisualStyleBackColor = true;
            this.rbtnOutput.CheckedChanged += new System.EventHandler(this.variableTypeChanged);
            // 
            // rbtnReqOut
            // 
            this.rbtnReqOut.AutoSize = true;
            this.rbtnReqOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnReqOut.Location = new System.Drawing.Point(3, 105);
            this.rbtnReqOut.Name = "rbtnReqOut";
            this.rbtnReqOut.Size = new System.Drawing.Size(448, 46);
            this.rbtnReqOut.TabIndex = 2;
            this.rbtnReqOut.TabStop = true;
            this.rbtnReqOut.Text = "Request-Output";
            this.rbtnReqOut.UseVisualStyleBackColor = true;
            this.rbtnReqOut.CheckedChanged += new System.EventHandler(this.variableTypeChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbQuestion);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Question";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Location = new System.Drawing.Point(3, 19);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(454, 23);
            this.tbQuestion.TabIndex = 0;
            // 
            // TLPVariableButtons
            // 
            this.TLPVariableButtons.ColumnCount = 3;
            this.TLPVariableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPVariableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TLPVariableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.TLPVariableButtons.Controls.Add(this.btnVariableOk, 1, 0);
            this.TLPVariableButtons.Controls.Add(this.btnVariableCancel, 2, 0);
            this.TLPVariableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPVariableButtons.Location = new System.Drawing.Point(3, 365);
            this.TLPVariableButtons.Name = "TLPVariableButtons";
            this.TLPVariableButtons.RowCount = 1;
            this.TLPVariableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPVariableButtons.Size = new System.Drawing.Size(460, 37);
            this.TLPVariableButtons.TabIndex = 4;
            // 
            // btnVariableOk
            // 
            this.btnVariableOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariableOk.Location = new System.Drawing.Point(325, 3);
            this.btnVariableOk.Name = "btnVariableOk";
            this.btnVariableOk.Size = new System.Drawing.Size(49, 31);
            this.btnVariableOk.TabIndex = 0;
            this.btnVariableOk.Text = "OK";
            this.btnVariableOk.UseVisualStyleBackColor = true;
            this.btnVariableOk.Click += new System.EventHandler(this.btnVariableOk_Click);
            // 
            // btnVariableCancel
            // 
            this.btnVariableCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariableCancel.Location = new System.Drawing.Point(380, 3);
            this.btnVariableCancel.Name = "btnVariableCancel";
            this.btnVariableCancel.Size = new System.Drawing.Size(77, 31);
            this.btnVariableCancel.TabIndex = 1;
            this.btnVariableCancel.Text = "Cancel";
            this.btnVariableCancel.UseVisualStyleBackColor = true;
            this.btnVariableCancel.Click += new System.EventHandler(this.btnVariableCancel_Click);
            // 
            // AddVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 405);
            this.Controls.Add(this.TLPVariableAll);
            this.Name = "AddVariableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddVariableForm";
            this.TLPVariableAll.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TLPVariableDomain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.TLPVariableType.ResumeLayout(false);
            this.TLPVariableType.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TLPVariableButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPVariableAll;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox tbVariableName;
        private TableLayoutPanel TLPVariableDomain;
        private TableLayoutPanel TLPVariableType;
        private Button btnAddDomain;
        private RadioButton rbtnRequested;
        private RadioButton rbtnOutput;
        private RadioButton rbtnReqOut;
        private TextBox tbQuestion;
        private ComboBox cbVariableDomain;
        private TableLayoutPanel TLPVariableButtons;
        private Button btnVariableOk;
        private Button btnVariableCancel;
    }
}