namespace MakeGuruGreatAgain.Forms
{
    partial class ConsultationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationForm));
            this.TLPConsultationForm = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvValuedVariables = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trvRules = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.expandAllbtn = new System.Windows.Forms.ToolStripButton();
            this.collapseAllbtn = new System.Windows.Forms.ToolStripButton();
            this.TLPConsultationForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValuedVariables)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPConsultationForm
            // 
            this.TLPConsultationForm.ColumnCount = 2;
            this.TLPConsultationForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPConsultationForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPConsultationForm.Controls.Add(this.groupBox1, 1, 0);
            this.TLPConsultationForm.Controls.Add(this.groupBox2, 0, 0);
            this.TLPConsultationForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPConsultationForm.Location = new System.Drawing.Point(0, 0);
            this.TLPConsultationForm.Name = "TLPConsultationForm";
            this.TLPConsultationForm.RowCount = 1;
            this.TLPConsultationForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPConsultationForm.Size = new System.Drawing.Size(1062, 535);
            this.TLPConsultationForm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvValuedVariables);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(746, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valued variables";
            // 
            // dgvValuedVariables
            // 
            this.dgvValuedVariables.AllowUserToAddRows = false;
            this.dgvValuedVariables.AllowUserToDeleteRows = false;
            this.dgvValuedVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValuedVariables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvValuedVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValuedVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Value});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValuedVariables.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvValuedVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValuedVariables.Location = new System.Drawing.Point(3, 19);
            this.dgvValuedVariables.MultiSelect = false;
            this.dgvValuedVariables.Name = "dgvValuedVariables";
            this.dgvValuedVariables.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvValuedVariables.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvValuedVariables.RowHeadersVisible = false;
            this.dgvValuedVariables.RowTemplate.Height = 25;
            this.dgvValuedVariables.Size = new System.Drawing.Size(307, 507);
            this.dgvValuedVariables.TabIndex = 0;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trvRules);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 529);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Explanation";
            // 
            // trvRules
            // 
            this.trvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvRules.Location = new System.Drawing.Point(3, 44);
            this.trvRules.Name = "trvRules";
            this.trvRules.PathSeparator = "\\n";
            this.trvRules.Size = new System.Drawing.Size(731, 482);
            this.trvRules.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllbtn,
            this.collapseAllbtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // expandAllbtn
            // 
            this.expandAllbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.expandAllbtn.Image = ((System.Drawing.Image)(resources.GetObject("expandAllbtn.Image")));
            this.expandAllbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.expandAllbtn.Name = "expandAllbtn";
            this.expandAllbtn.Size = new System.Drawing.Size(65, 22);
            this.expandAllbtn.Text = "Expand all";
            this.expandAllbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.expandAllbtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // collapseAllbtn
            // 
            this.collapseAllbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.collapseAllbtn.Image = ((System.Drawing.Image)(resources.GetObject("collapseAllbtn.Image")));
            this.collapseAllbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collapseAllbtn.Name = "collapseAllbtn";
            this.collapseAllbtn.Size = new System.Drawing.Size(71, 22);
            this.collapseAllbtn.Text = "Collapse all";
            this.collapseAllbtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 535);
            this.Controls.Add(this.TLPConsultationForm);
            this.Name = "ConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultationForm_FormClosed);
            this.TLPConsultationForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValuedVariables)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPConsultationForm;
        private GroupBox groupBox1;
        private DataGridView dgvValuedVariables;
        private DataGridViewTextBoxColumn Variable;
        private DataGridViewTextBoxColumn Value;
        private GroupBox groupBox2;
        private TreeView trvRules;
        private ToolStrip toolStrip1;
        private ToolStripButton expandAllbtn;
        private ToolStripButton collapseAllbtn;
    }
}