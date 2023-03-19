namespace MakeGuruGreatAgain.Forms
{
    partial class AddDomainForm
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
            this.TLPDomainAll = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxDomainValues = new System.Windows.Forms.ListBox();
            this.btnDeleteDomainValue = new System.Windows.Forms.Button();
            this.TLPEditDomainValues = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDomainValue = new System.Windows.Forms.Button();
            this.btnEditDomainValue = new System.Windows.Forms.Button();
            this.tbDomainValue = new System.Windows.Forms.TextBox();
            this.TLPSaveDomain = new System.Windows.Forms.TableLayoutPanel();
            this.btnDomainOK = new System.Windows.Forms.Button();
            this.btnDomainCancel = new System.Windows.Forms.Button();
            this.TLPDomainAll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TLPEditDomainValues.SuspendLayout();
            this.TLPSaveDomain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPDomainAll
            // 
            this.TLPDomainAll.ColumnCount = 1;
            this.TLPDomainAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPDomainAll.Controls.Add(this.groupBox1, 0, 0);
            this.TLPDomainAll.Controls.Add(this.groupBox2, 0, 1);
            this.TLPDomainAll.Controls.Add(this.TLPEditDomainValues, 0, 2);
            this.TLPDomainAll.Controls.Add(this.TLPSaveDomain, 0, 3);
            this.TLPDomainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPDomainAll.Location = new System.Drawing.Point(0, 0);
            this.TLPDomainAll.Name = "TLPDomainAll";
            this.TLPDomainAll.RowCount = 4;
            this.TLPDomainAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPDomainAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TLPDomainAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPDomainAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPDomainAll.Size = new System.Drawing.Size(460, 382);
            this.TLPDomainAll.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDomainName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domain name";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDomainName.Location = new System.Drawing.Point(3, 19);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(448, 23);
            this.tbDomainName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxDomainValues);
            this.groupBox2.Controls.Add(this.btnDeleteDomainValue);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain values";
            // 
            // lbxDomainValues
            // 
            this.lbxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDomainValues.FormattingEnabled = true;
            this.lbxDomainValues.ItemHeight = 15;
            this.lbxDomainValues.Location = new System.Drawing.Point(3, 19);
            this.lbxDomainValues.Name = "lbxDomainValues";
            this.lbxDomainValues.Size = new System.Drawing.Size(448, 197);
            this.lbxDomainValues.TabIndex = 0;
            this.lbxDomainValues.SelectedIndexChanged += new System.EventHandler(this.lbxDomainValues_SelectedIndexChanged);
            this.lbxDomainValues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbxDomainValues_KeyUp);
            // 
            // btnDeleteDomainValue
            // 
            this.btnDeleteDomainValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteDomainValue.Location = new System.Drawing.Point(3, 216);
            this.btnDeleteDomainValue.Name = "btnDeleteDomainValue";
            this.btnDeleteDomainValue.Size = new System.Drawing.Size(448, 23);
            this.btnDeleteDomainValue.TabIndex = 1;
            this.btnDeleteDomainValue.Text = "Delete value";
            this.btnDeleteDomainValue.UseVisualStyleBackColor = true;
            this.btnDeleteDomainValue.Click += new System.EventHandler(this.btnDeleteDomainValue_Click);
            // 
            // TLPEditDomainValues
            // 
            this.TLPEditDomainValues.ColumnCount = 3;
            this.TLPEditDomainValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPEditDomainValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditDomainValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPEditDomainValues.Controls.Add(this.btnAddDomainValue, 1, 0);
            this.TLPEditDomainValues.Controls.Add(this.btnEditDomainValue, 2, 0);
            this.TLPEditDomainValues.Controls.Add(this.tbDomainValue, 0, 0);
            this.TLPEditDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPEditDomainValues.Location = new System.Drawing.Point(3, 308);
            this.TLPEditDomainValues.Name = "TLPEditDomainValues";
            this.TLPEditDomainValues.RowCount = 1;
            this.TLPEditDomainValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPEditDomainValues.Size = new System.Drawing.Size(454, 32);
            this.TLPEditDomainValues.TabIndex = 2;
            // 
            // btnAddDomainValue
            // 
            this.btnAddDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDomainValue.Location = new System.Drawing.Point(230, 3);
            this.btnAddDomainValue.Name = "btnAddDomainValue";
            this.btnAddDomainValue.Size = new System.Drawing.Size(107, 26);
            this.btnAddDomainValue.TabIndex = 0;
            this.btnAddDomainValue.Text = "Add value";
            this.btnAddDomainValue.UseVisualStyleBackColor = true;
            this.btnAddDomainValue.Click += new System.EventHandler(this.btnAddDomainValue_Click);
            // 
            // btnEditDomainValue
            // 
            this.btnEditDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDomainValue.Location = new System.Drawing.Point(343, 3);
            this.btnEditDomainValue.Name = "btnEditDomainValue";
            this.btnEditDomainValue.Size = new System.Drawing.Size(108, 26);
            this.btnEditDomainValue.TabIndex = 1;
            this.btnEditDomainValue.Text = "Edit value";
            this.btnEditDomainValue.UseVisualStyleBackColor = true;
            this.btnEditDomainValue.Click += new System.EventHandler(this.btnEditDomainValue_Click);
            // 
            // tbDomainValue
            // 
            this.tbDomainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDomainValue.Location = new System.Drawing.Point(3, 3);
            this.tbDomainValue.Name = "tbDomainValue";
            this.tbDomainValue.Size = new System.Drawing.Size(221, 23);
            this.tbDomainValue.TabIndex = 2;
            // 
            // TLPSaveDomain
            // 
            this.TLPSaveDomain.ColumnCount = 3;
            this.TLPSaveDomain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPSaveDomain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TLPSaveDomain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.TLPSaveDomain.Controls.Add(this.btnDomainOK, 1, 0);
            this.TLPSaveDomain.Controls.Add(this.btnDomainCancel, 2, 0);
            this.TLPSaveDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPSaveDomain.Location = new System.Drawing.Point(3, 346);
            this.TLPSaveDomain.Name = "TLPSaveDomain";
            this.TLPSaveDomain.RowCount = 1;
            this.TLPSaveDomain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPSaveDomain.Size = new System.Drawing.Size(454, 33);
            this.TLPSaveDomain.TabIndex = 3;
            // 
            // btnDomainOK
            // 
            this.btnDomainOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDomainOK.Location = new System.Drawing.Point(320, 3);
            this.btnDomainOK.Name = "btnDomainOK";
            this.btnDomainOK.Size = new System.Drawing.Size(48, 27);
            this.btnDomainOK.TabIndex = 0;
            this.btnDomainOK.Text = "OK";
            this.btnDomainOK.UseVisualStyleBackColor = true;
            this.btnDomainOK.Click += new System.EventHandler(this.btnDomainOK_Click);
            // 
            // btnDomainCancel
            // 
            this.btnDomainCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDomainCancel.Location = new System.Drawing.Point(374, 3);
            this.btnDomainCancel.Name = "btnDomainCancel";
            this.btnDomainCancel.Size = new System.Drawing.Size(77, 27);
            this.btnDomainCancel.TabIndex = 1;
            this.btnDomainCancel.Text = "Cancel";
            this.btnDomainCancel.UseVisualStyleBackColor = true;
            this.btnDomainCancel.Click += new System.EventHandler(this.btnDomainCancel_Click);
            // 
            // AddDomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.TLPDomainAll);
            this.Name = "AddDomainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDomainForm";
            this.TLPDomainAll.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TLPEditDomainValues.ResumeLayout(false);
            this.TLPEditDomainValues.PerformLayout();
            this.TLPSaveDomain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPDomainAll;
        private GroupBox groupBox1;
        private TextBox tbDomainName;
        private GroupBox groupBox2;
        private ListBox lbxDomainValues;
        private TableLayoutPanel TLPEditDomainValues;
        private Button btnAddDomainValue;
        private Button btnEditDomainValue;
        private TextBox tbDomainValue;
        private Button btnDeleteDomainValue;
        private TableLayoutPanel TLPSaveDomain;
        private Button btnDomainOK;
        private Button btnDomainCancel;
    }
}