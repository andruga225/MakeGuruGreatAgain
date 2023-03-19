namespace MakeGuruGreatAgain.Forms
{
    partial class AddRuleForm
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
            this.TLPMainRuleForm = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.TLPEditRule = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TLPRulePremise = new System.Windows.Forms.TableLayoutPanel();
            this.TLPRulePremiseButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPremise = new System.Windows.Forms.Button();
            this.btnEditPremise = new System.Windows.Forms.Button();
            this.btnDeletePremise = new System.Windows.Forms.Button();
            this.lbxPremise = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TLPRuleConclusion = new System.Windows.Forms.TableLayoutPanel();
            this.TLPRuleConclusionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddConclusion = new System.Windows.Forms.Button();
            this.btnEditConclusion = new System.Windows.Forms.Button();
            this.btnDeleteConclusion = new System.Windows.Forms.Button();
            this.lbxConclusion = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.TLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRuleOk = new System.Windows.Forms.Button();
            this.btnRuleCancel = new System.Windows.Forms.Button();
            this.TLPMainRuleForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TLPEditRule.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TLPRulePremise.SuspendLayout();
            this.TLPRulePremiseButtons.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TLPRuleConclusion.SuspendLayout();
            this.TLPRuleConclusionButtons.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TLPButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMainRuleForm
            // 
            this.TLPMainRuleForm.ColumnCount = 1;
            this.TLPMainRuleForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMainRuleForm.Controls.Add(this.groupBox1, 0, 0);
            this.TLPMainRuleForm.Controls.Add(this.TLPEditRule, 0, 1);
            this.TLPMainRuleForm.Controls.Add(this.groupBox4, 0, 2);
            this.TLPMainRuleForm.Controls.Add(this.TLPButtons, 0, 3);
            this.TLPMainRuleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMainRuleForm.Location = new System.Drawing.Point(0, 0);
            this.TLPMainRuleForm.Name = "TLPMainRuleForm";
            this.TLPMainRuleForm.RowCount = 4;
            this.TLPMainRuleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPMainRuleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLPMainRuleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPMainRuleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPMainRuleForm.Size = new System.Drawing.Size(546, 426);
            this.TLPMainRuleForm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRuleName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule name";
            // 
            // tbRuleName
            // 
            this.tbRuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRuleName.Location = new System.Drawing.Point(3, 19);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(534, 23);
            this.tbRuleName.TabIndex = 0;
            // 
            // TLPEditRule
            // 
            this.TLPEditRule.ColumnCount = 2;
            this.TLPEditRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPEditRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPEditRule.Controls.Add(this.groupBox2, 0, 0);
            this.TLPEditRule.Controls.Add(this.groupBox3, 1, 0);
            this.TLPEditRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPEditRule.Location = new System.Drawing.Point(3, 66);
            this.TLPEditRule.Name = "TLPEditRule";
            this.TLPEditRule.RowCount = 1;
            this.TLPEditRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPEditRule.Size = new System.Drawing.Size(540, 249);
            this.TLPEditRule.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TLPRulePremise);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Premise";
            // 
            // TLPRulePremise
            // 
            this.TLPRulePremise.ColumnCount = 1;
            this.TLPRulePremise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPRulePremise.Controls.Add(this.TLPRulePremiseButtons, 0, 1);
            this.TLPRulePremise.Controls.Add(this.lbxPremise, 0, 0);
            this.TLPRulePremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRulePremise.Location = new System.Drawing.Point(3, 19);
            this.TLPRulePremise.Name = "TLPRulePremise";
            this.TLPRulePremise.RowCount = 2;
            this.TLPRulePremise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TLPRulePremise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPRulePremise.Size = new System.Drawing.Size(258, 221);
            this.TLPRulePremise.TabIndex = 0;
            // 
            // TLPRulePremiseButtons
            // 
            this.TLPRulePremiseButtons.ColumnCount = 3;
            this.TLPRulePremiseButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRulePremiseButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRulePremiseButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRulePremiseButtons.Controls.Add(this.btnAddPremise, 0, 0);
            this.TLPRulePremiseButtons.Controls.Add(this.btnEditPremise, 1, 0);
            this.TLPRulePremiseButtons.Controls.Add(this.btnDeletePremise, 2, 0);
            this.TLPRulePremiseButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRulePremiseButtons.Location = new System.Drawing.Point(3, 190);
            this.TLPRulePremiseButtons.Name = "TLPRulePremiseButtons";
            this.TLPRulePremiseButtons.RowCount = 1;
            this.TLPRulePremiseButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPRulePremiseButtons.Size = new System.Drawing.Size(252, 28);
            this.TLPRulePremiseButtons.TabIndex = 0;
            // 
            // btnAddPremise
            // 
            this.btnAddPremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPremise.Location = new System.Drawing.Point(3, 3);
            this.btnAddPremise.Name = "btnAddPremise";
            this.btnAddPremise.Size = new System.Drawing.Size(78, 22);
            this.btnAddPremise.TabIndex = 0;
            this.btnAddPremise.Text = "Add";
            this.btnAddPremise.UseVisualStyleBackColor = true;
            this.btnAddPremise.Click += new System.EventHandler(this.btnAddPremise_Click);
            // 
            // btnEditPremise
            // 
            this.btnEditPremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditPremise.Location = new System.Drawing.Point(87, 3);
            this.btnEditPremise.Name = "btnEditPremise";
            this.btnEditPremise.Size = new System.Drawing.Size(78, 22);
            this.btnEditPremise.TabIndex = 1;
            this.btnEditPremise.Text = "Edit";
            this.btnEditPremise.UseVisualStyleBackColor = true;
            this.btnEditPremise.Click += new System.EventHandler(this.btnEditPremise_Click);
            // 
            // btnDeletePremise
            // 
            this.btnDeletePremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletePremise.Location = new System.Drawing.Point(171, 3);
            this.btnDeletePremise.Name = "btnDeletePremise";
            this.btnDeletePremise.Size = new System.Drawing.Size(78, 22);
            this.btnDeletePremise.TabIndex = 2;
            this.btnDeletePremise.Text = "Delete";
            this.btnDeletePremise.UseVisualStyleBackColor = true;
            this.btnDeletePremise.Click += new System.EventHandler(this.btnDeletePremise_Click);
            // 
            // lbxPremise
            // 
            this.lbxPremise.AllowDrop = true;
            this.lbxPremise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPremise.FormattingEnabled = true;
            this.lbxPremise.ItemHeight = 15;
            this.lbxPremise.Location = new System.Drawing.Point(3, 3);
            this.lbxPremise.Name = "lbxPremise";
            this.lbxPremise.Size = new System.Drawing.Size(252, 181);
            this.lbxPremise.TabIndex = 1;
            this.lbxPremise.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxPremise_DragDrop);
            this.lbxPremise.DragOver += new System.Windows.Forms.DragEventHandler(this.lbxPremise_DragOver);
            this.lbxPremise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxPremise_MouseDown);
            this.lbxPremise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxPremise_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TLPRuleConclusion);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(273, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 243);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conclusion";
            // 
            // TLPRuleConclusion
            // 
            this.TLPRuleConclusion.ColumnCount = 1;
            this.TLPRuleConclusion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPRuleConclusion.Controls.Add(this.TLPRuleConclusionButtons, 0, 1);
            this.TLPRuleConclusion.Controls.Add(this.lbxConclusion, 0, 0);
            this.TLPRuleConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRuleConclusion.Location = new System.Drawing.Point(3, 19);
            this.TLPRuleConclusion.Name = "TLPRuleConclusion";
            this.TLPRuleConclusion.RowCount = 2;
            this.TLPRuleConclusion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TLPRuleConclusion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPRuleConclusion.Size = new System.Drawing.Size(258, 221);
            this.TLPRuleConclusion.TabIndex = 0;
            // 
            // TLPRuleConclusionButtons
            // 
            this.TLPRuleConclusionButtons.ColumnCount = 3;
            this.TLPRuleConclusionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRuleConclusionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRuleConclusionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPRuleConclusionButtons.Controls.Add(this.btnAddConclusion, 0, 0);
            this.TLPRuleConclusionButtons.Controls.Add(this.btnEditConclusion, 1, 0);
            this.TLPRuleConclusionButtons.Controls.Add(this.btnDeleteConclusion, 2, 0);
            this.TLPRuleConclusionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRuleConclusionButtons.Location = new System.Drawing.Point(3, 190);
            this.TLPRuleConclusionButtons.Name = "TLPRuleConclusionButtons";
            this.TLPRuleConclusionButtons.RowCount = 1;
            this.TLPRuleConclusionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPRuleConclusionButtons.Size = new System.Drawing.Size(252, 28);
            this.TLPRuleConclusionButtons.TabIndex = 0;
            // 
            // btnAddConclusion
            // 
            this.btnAddConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddConclusion.Location = new System.Drawing.Point(3, 3);
            this.btnAddConclusion.Name = "btnAddConclusion";
            this.btnAddConclusion.Size = new System.Drawing.Size(78, 22);
            this.btnAddConclusion.TabIndex = 0;
            this.btnAddConclusion.Text = "Add";
            this.btnAddConclusion.UseVisualStyleBackColor = true;
            this.btnAddConclusion.Click += new System.EventHandler(this.btnAddConclusion_Click);
            // 
            // btnEditConclusion
            // 
            this.btnEditConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditConclusion.Location = new System.Drawing.Point(87, 3);
            this.btnEditConclusion.Name = "btnEditConclusion";
            this.btnEditConclusion.Size = new System.Drawing.Size(78, 22);
            this.btnEditConclusion.TabIndex = 1;
            this.btnEditConclusion.Text = "Edit";
            this.btnEditConclusion.UseVisualStyleBackColor = true;
            this.btnEditConclusion.Click += new System.EventHandler(this.btnEditConclusion_Click);
            // 
            // btnDeleteConclusion
            // 
            this.btnDeleteConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteConclusion.Location = new System.Drawing.Point(171, 3);
            this.btnDeleteConclusion.Name = "btnDeleteConclusion";
            this.btnDeleteConclusion.Size = new System.Drawing.Size(78, 22);
            this.btnDeleteConclusion.TabIndex = 2;
            this.btnDeleteConclusion.Text = "Delete";
            this.btnDeleteConclusion.UseVisualStyleBackColor = true;
            this.btnDeleteConclusion.Click += new System.EventHandler(this.btnDeleteConclusion_Click);
            // 
            // lbxConclusion
            // 
            this.lbxConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxConclusion.FormattingEnabled = true;
            this.lbxConclusion.ItemHeight = 15;
            this.lbxConclusion.Location = new System.Drawing.Point(3, 3);
            this.lbxConclusion.Name = "lbxConclusion";
            this.lbxConclusion.Size = new System.Drawing.Size(252, 181);
            this.lbxConclusion.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbReason);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 57);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReason.Location = new System.Drawing.Point(3, 19);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReason.Size = new System.Drawing.Size(534, 35);
            this.tbReason.TabIndex = 0;
            // 
            // TLPButtons
            // 
            this.TLPButtons.ColumnCount = 3;
            this.TLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.TLPButtons.Controls.Add(this.btnRuleOk, 1, 0);
            this.TLPButtons.Controls.Add(this.btnRuleCancel, 2, 0);
            this.TLPButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPButtons.Location = new System.Drawing.Point(3, 384);
            this.TLPButtons.Name = "TLPButtons";
            this.TLPButtons.RowCount = 1;
            this.TLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPButtons.Size = new System.Drawing.Size(540, 39);
            this.TLPButtons.TabIndex = 3;
            // 
            // btnRuleOk
            // 
            this.btnRuleOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRuleOk.Location = new System.Drawing.Point(381, 3);
            this.btnRuleOk.Name = "btnRuleOk";
            this.btnRuleOk.Size = new System.Drawing.Size(58, 33);
            this.btnRuleOk.TabIndex = 0;
            this.btnRuleOk.Text = "OK";
            this.btnRuleOk.UseVisualStyleBackColor = true;
            this.btnRuleOk.Click += new System.EventHandler(this.btnRuleOk_Click);
            // 
            // btnRuleCancel
            // 
            this.btnRuleCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRuleCancel.Location = new System.Drawing.Point(445, 3);
            this.btnRuleCancel.Name = "btnRuleCancel";
            this.btnRuleCancel.Size = new System.Drawing.Size(92, 33);
            this.btnRuleCancel.TabIndex = 1;
            this.btnRuleCancel.Text = "Cancel";
            this.btnRuleCancel.UseVisualStyleBackColor = true;
            this.btnRuleCancel.Click += new System.EventHandler(this.btnRuleCancel_Click);
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.TLPMainRuleForm);
            this.Name = "AddRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRuleForm";
            this.TLPMainRuleForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TLPEditRule.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.TLPRulePremise.ResumeLayout(false);
            this.TLPRulePremiseButtons.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.TLPRuleConclusion.ResumeLayout(false);
            this.TLPRuleConclusionButtons.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TLPButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPMainRuleForm;
        private GroupBox groupBox1;
        private TableLayoutPanel TLPEditRule;
        private GroupBox groupBox2;
        private TableLayoutPanel TLPRulePremise;
        private TableLayoutPanel TLPRulePremiseButtons;
        private GroupBox groupBox3;
        private TableLayoutPanel TLPRuleConclusion;
        private TableLayoutPanel TLPRuleConclusionButtons;
        private Button btnAddPremise;
        private Button btnEditPremise;
        private Button btnDeletePremise;
        private ListBox lbxPremise;
        private Button btnAddConclusion;
        private Button btnEditConclusion;
        private Button btnDeleteConclusion;
        private ListBox lbxConclusion;
        private TextBox tbRuleName;
        private GroupBox groupBox4;
        private TextBox tbReason;
        private TableLayoutPanel TLPButtons;
        private Button btnRuleOk;
        private Button btnRuleCancel;
    }
}