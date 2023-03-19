using MakeGuruGreatAgain.Forms;
using MakeGuruGreatAgain.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace MakeGuruGreatAgain
{
    public partial class KnowledgeBaseForm : Form
    {
        private ExpertSystem expertSystem;
        //private KnowledgeBase knowledgeBase = new KnowledgeBase();
        private bool isExists = false;
        private bool isSave = true;
        private string openedFilePath;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public KnowledgeBaseForm()
        {
            InitializeComponent();
            expertSystem = new ExpertSystem();
        }

        #region DomainTab

        private void refreshDgvDomains()
        {
            dgvDomains.Rows.Clear();

            foreach (var domain in expertSystem.KnowledgeBase.Domains)
            {
                dgvDomains.Rows.Add(domain.Name, string.Join("/", domain.Values));
            }
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            isSave = false;

            var domain = new AddDomainForm(expertSystem.KnowledgeBase.Domains);
            domain.ShowDialog();

            if(domain.DialogResult == DialogResult.OK)
            {
                expertSystem.KnowledgeBase.Domains.Add(new Domain(domain.domainName, domain.domainValues));
                dgvDomains.Rows.Add(domain.domainName, string.Join("/", domain.domainValues));
                
            }
        }

        private void dgvDomains_SelectionChanged(object sender, EventArgs e)
        {
            lbxDomainValues.Items.Clear();

            if (dgvDomains.Rows.Count > 0)
            {
                lbxDomainValues.Items.AddRange(expertSystem.KnowledgeBase.Domains.First(dm => dm.Name == dgvDomains.CurrentRow.Cells[0].Value).Values.ToArray());
            }
        }

        private void btnEditDomain_Click(object sender, EventArgs e)
        {
            if(dgvDomains.SelectedRows.Count > 0)
            {
                isSave = false;

                var editDomain = expertSystem.KnowledgeBase.Domains.First(dm => dm.Name == dgvDomains.SelectedRows[0].Cells[0].Value);

                var domain = new AddDomainForm(editDomain.Name,
                    editDomain.Values, expertSystem.KnowledgeBase.Domains);

                domain.ShowDialog();

                if(domain.DialogResult == DialogResult.OK)
                {
                    expertSystem.KnowledgeBase.Domains[dgvDomains.CurrentCell.RowIndex].Name = domain.domainName;
                    expertSystem.KnowledgeBase.Domains[dgvDomains.CurrentCell.RowIndex].Values = domain.domainValues;

                    dgvDomains.Rows[dgvDomains.CurrentCell.RowIndex].Cells[0].Value = domain.domainName;
                    dgvDomains.Rows[dgvDomains.CurrentCell.RowIndex].Cells[1].Value = string.Join("/", domain.domainValues);

                    refreshDgvVariables();

                    dgvDomains_SelectionChanged(sender, e);
                }
            }
        }

        private void btnDeleteDomain_Click(object sender, EventArgs e)
        {
            if(dgvDomains.SelectedRows.Count > 0)
            {
                isSave = false;

                expertSystem.KnowledgeBase.Domains.RemoveAt(dgvDomains.CurrentCell.RowIndex);
                dgvDomains.Rows.RemoveAt(dgvDomains.CurrentCell.RowIndex);

                lbxDomainValues.Items.Clear();
            }
        }

        #endregion

        #region VariablesTab

        private void refreshDgvVariables()
        {
            dgvVariables.Rows.Clear();

            foreach (var variable in expertSystem.KnowledgeBase.Variables)
            {
                dgvVariables.Rows.Add(variable.Name, variable.Type.ToString(), variable.Domain.Name);
            }
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            isSave = false;

            var variable = new AddVariableForm(expertSystem.KnowledgeBase.Domains, expertSystem.KnowledgeBase.Variables);

            variable.ShowDialog();

            if(variable.DialogResult == DialogResult.OK)
            {
                expertSystem.KnowledgeBase.Variables.Add(new Variable(variable.variableName, variable.variableType, variable.variableDomain, variable.variableQuestion));
                dgvVariables.Rows.Add(variable.variableName, variable.variableType.ToString(), variable.variableDomain.Name);
            }

            expertSystem.KnowledgeBase.Domains = variable.domains;
            refreshDgvDomains();
        }

        private void btnEditVariable_Click(object sender, EventArgs e)
        {
            isSave = false;

            if (dgvVariables.SelectedRows.Count > 0)
            {
                var editVariable = expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index];

                var variable = new AddVariableForm(editVariable.Name, editVariable.Type, editVariable.Domain, editVariable.Question,
                    expertSystem.KnowledgeBase.Domains, expertSystem.KnowledgeBase.Variables);

                variable.ShowDialog();

                if(variable.DialogResult == DialogResult.OK)
                {
                    expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index].Name = variable.variableName;
                    expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index].Type = variable.variableType;
                    expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index].Domain = variable.variableDomain;
                    expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index].Question = variable.variableQuestion;

                    dgvVariables.CurrentRow.Cells[0].Value = variable.variableName;
                    dgvVariables.CurrentRow.Cells[1].Value = variable.variableType.ToString();
                    dgvVariables.CurrentRow.Cells[2].Value = variable.variableDomain.Name;

                }

                expertSystem.KnowledgeBase.Domains = variable.domains;
                refreshDgvDomains();
            }
        }

        private void dgvVariables_SelectionChanged(object sender, EventArgs e)
        {
            lbxVariableDomainValues.Items.Clear();
            lbxVariableUsing.Items.Clear();

            if (dgvVariables.SelectedRows.Count > 0)
            {

                tbVariableQuestion.Text = expertSystem.KnowledgeBase.Variables[dgvVariables.CurrentRow.Index].Question;
                lbxVariableDomainValues.Items.AddRange(expertSystem.KnowledgeBase.Variables
                    .First(var => var.Domain.Name == dgvVariables.CurrentRow.Cells[2].Value)
                    .Domain.Values.ToArray());

                List<string> rules = new List<string>();

                //rules.AddRange(knowledgeBase.Rules.All(rule => rule.Premise.Contains(rule.Premise.Any(st => dgvVariables.CurrentRow.Cells[0].Value == st.Variable.Name))));
                expertSystem.KnowledgeBase.Rules
                    .ForEach(rule => rule.Premise
                    .ForEach(pr =>
                    {
                        if (pr.Variable.Name == dgvVariables.CurrentRow.Cells[0].Value && !rules.Contains(rule.Name))
                        {
                            rules.Add(rule.Name);
                        }
                    }));

                expertSystem.KnowledgeBase.Rules
                    .ForEach(rule => rule.Conclusion
                    .ForEach(pr =>
                    {
                        if (pr.Variable.Name == dgvVariables.CurrentRow.Cells[0].Value && !rules.Contains(rule.Name))
                        {
                            rules.Add(rule.Name);
                        }
                    }));

                lbxVariableUsing.Items.AddRange(rules.ToArray());
            }
        }

        private void btnDeleteVariable_Click(object sender, EventArgs e)
        {
            isSave = false;

            if (dgvVariables.SelectedRows.Count > 0)
            {
                expertSystem.KnowledgeBase.Variables.RemoveAt(dgvVariables.CurrentCell.RowIndex);
                dgvVariables.Rows.RemoveAt(dgvVariables.CurrentCell.RowIndex);

                tbVariableQuestion.Text = string.Empty;
                lbxVariableDomainValues.Items.Clear();
                lbxVariableUsing.Items.Clear();
            }
        }

        #endregion

        #region RulesTab

        private void refreshDgvRules()
        {
            dgvRules.Rows.Clear();

            foreach (var rule in expertSystem.KnowledgeBase.Rules)
            {
                dgvRules.Rows.Add(rule.Name, rule.RuleDescription());
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            isSave = false;

            var rule = new AddRuleForm(expertSystem.KnowledgeBase.Rules, expertSystem.KnowledgeBase.Variables, expertSystem.KnowledgeBase.Domains);

            rule.ShowDialog();

            if(rule.DialogResult == DialogResult.OK)
            {
                var newRule = new Rule(rule.ruleName, rule.premise, rule.conclusion, rule.reason);
                
                if(dgvRules.SelectedRows.Count > 0)
                {
                    expertSystem.KnowledgeBase.Rules.Insert(dgvRules.SelectedRows[0].Index + 1, newRule);
                    dgvRules.Rows.Insert(dgvRules.SelectedRows[0].Index + 1, rule.ruleName, newRule.RuleDescription());
                }
                else
                {
                    expertSystem.KnowledgeBase.Rules.Add(newRule);
                    dgvRules.Rows.Add(rule.ruleName, newRule.RuleDescription());
                }

                
            }

            expertSystem.KnowledgeBase.Domains = rule.domains;
            expertSystem.KnowledgeBase.Variables = rule.variables;

            refreshDgvDomains();
            refreshDgvVariables();
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                isSave = false;

                var editRule = expertSystem.KnowledgeBase.Rules.First(r => r.Name == dgvRules.CurrentRow.Cells[0].Value);

                var rule = new AddRuleForm(editRule.Name, editRule.Premise, editRule.Conclusion, editRule.Reason,
                    expertSystem.KnowledgeBase.Rules, expertSystem.KnowledgeBase.Domains, expertSystem.KnowledgeBase.Variables);

                rule.ShowDialog();

                if(rule.DialogResult == DialogResult.OK)
                {
                    var newRule = new Rule(rule.ruleName, rule.premise, rule.conclusion, rule.reason);

                    expertSystem.KnowledgeBase.Rules[dgvRules.CurrentRow.Index].Name = rule.ruleName;
                    expertSystem.KnowledgeBase.Rules[dgvRules.CurrentRow.Index].Premise = rule.premise;
                    expertSystem.KnowledgeBase.Rules[dgvRules.CurrentRow.Index].Conclusion = rule.conclusion;
                    expertSystem.KnowledgeBase.Rules[dgvRules.CurrentRow.Index].Reason = rule.reason;

                    dgvRules.CurrentRow.Cells[0].Value = rule.ruleName;
                    dgvRules.CurrentRow.Cells[1].Value = newRule.RuleDescription();
                }

                expertSystem.KnowledgeBase.Domains = rule.domains;
                expertSystem.KnowledgeBase.Variables = rule.variables;

                refreshDgvDomains();
                refreshDgvVariables();
            }
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (dgvRules.SelectedRows.Count > 0)
            {
                isSave = false;

                dgvRules.Rows.RemoveAt(dgvRules.CurrentRow.Index);
                expertSystem.KnowledgeBase.Rules.RemoveAt(dgvRules.CurrentRow.Index);

                lbxPremise.Items.Clear();
                lbxConclusion.Items.Clear();

                refreshDgvVariables();
                refreshDgvRules();
            }
        }

        private void dgvRules_SelectionChanged(object sender, EventArgs e)
        {
            lbxPremise.Items.Clear();
            lbxConclusion.Items.Clear();

            if (dgvRules.SelectedRows.Count > 0)
            {
                lbxPremise.Items.AddRange(expertSystem.KnowledgeBase.Rules.FirstOrDefault(rule => rule.Name == dgvRules.CurrentRow.Cells[0].Value).Premise.ToArray());
                lbxConclusion.Items.AddRange(expertSystem.KnowledgeBase.Rules.FirstOrDefault(rule => rule.Name == dgvRules.CurrentRow.Cells[0].Value).Conclusion.ToArray());
            }
        }

        private void dgvRules_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvRules.DoDragDrop(
                    dgvRules.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void dgvRules_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvRules.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvRules_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvRules_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvRules.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgvRules.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dgvRules.Rows.RemoveAt(rowIndexFromMouseDown);
                try
                {
                    dgvRules.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    var t = expertSystem.KnowledgeBase.Rules[rowIndexFromMouseDown];
                    expertSystem.KnowledgeBase.Rules[rowIndexFromMouseDown] = expertSystem.KnowledgeBase.Rules[rowIndexOfItemUnderMouseToDrop];
                    expertSystem.KnowledgeBase.Rules[rowIndexOfItemUnderMouseToDrop] = t;
                }
                catch
                {
                    dgvRules.Rows.Insert(dgvRules.Rows.Count, rowToMove);
                    var t = expertSystem.KnowledgeBase.Rules[rowIndexFromMouseDown];
                    expertSystem.KnowledgeBase.Rules[rowIndexFromMouseDown] = expertSystem.KnowledgeBase.Rules[dgvRules.Rows.Count - 1];
                    expertSystem.KnowledgeBase.Rules[dgvRules.Rows.Count - 1] = t;
                }

            }
        }

        #endregion

        #region MenuButtons
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isExists)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream writer = new FileStream(openedFilePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(writer, expertSystem);
                    isSave = true;
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Binary files(*.bin)|*.bin";
                saveFileDialog.DefaultExt = "bin";
                saveFileDialog.AddExtension = true;
                saveFileDialog.CreatePrompt = true;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    using (FileStream writer = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(writer, expertSystem);
                        isSave = true;
                        openedFilePath = saveFileDialog.FileName;
                        this.Text = saveFileDialog.FileName;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                var res = MessageBox.Show("Are you sure you want to exit? All unsaved data will be lost!", "Exit", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Binary files(*.bin)|*.bin";
                    openFileDialog.DefaultExt = "bin";
                    openFileDialog.AddExtension = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream reader = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            this.Text = openFileDialog.FileName;
                            openedFilePath = openFileDialog.FileName;
                            isExists = true;
                            BinaryFormatter formatter = new BinaryFormatter();

                            expertSystem = (ExpertSystem)formatter.Deserialize(reader);
                            refreshDgvDomains();
                            refreshDgvRules();
                            refreshDgvVariables();
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Binary files(*.bin)|*.bin";
                openFileDialog.DefaultExt = "bin";
                openFileDialog.AddExtension = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream reader = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        this.Text = openFileDialog.FileName;
                        openedFilePath = openFileDialog.FileName;
                        isExists = true;
                        BinaryFormatter formatter = new BinaryFormatter();

                        expertSystem = (ExpertSystem)formatter.Deserialize(reader);
                        refreshDgvDomains();
                        refreshDgvRules();
                        refreshDgvVariables();
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                var res = MessageBox.Show("Are you sure you want to exit? All unsaved data will be lost!", "Exit", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Close();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isSave)
            {
                var res = MessageBox.Show("Are you sure you want to create new knowladge base? All unsaved data will be lost!", "Exit", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    expertSystem = new ExpertSystem();
                    isExists = false;
                    isSave = true;
                    refreshDgvDomains();
                    refreshDgvVariables();
                    refreshDgvRules();
                }
                else
                {
                    return;
                }
            }
            else
            {
                expertSystem = new ExpertSystem();
                isExists = false;
                isSave = true;
                refreshDgvDomains();
                refreshDgvVariables();
                refreshDgvRules();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "bin";
            saveFileDialog.AddExtension = true;
            saveFileDialog.CreatePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream writer = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(writer, expertSystem);
                    isSave = true;
                    openedFilePath = saveFileDialog.FileName;
                    this.Text = saveFileDialog.FileName;
                    isExists = true;
                }
            }
        }

        private void startConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(expertSystem.KnowledgeBase.Rules.Count == 0)
            {
                MessageBox.Show("Rule list is empty!");
                return;
            }

            var cons = new ConsultationForm(expertSystem.KnowledgeBase.Variables.FindAll(var => var.Type != Model.VariableType.Requested), expertSystem.KnowledgeBase.Rules);
            this.Visible = false;
            cons.ShowDialog();
            isSave = false;
            expertSystem.ExplanationComponent.Explanation = cons.rootNode;
            expertSystem.WorkingMemory.Variables = cons.valuedVariables;
            Visible = true;
        }

        private void lastConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(expertSystem.ExplanationComponent.Explanation.Nodes.Count == 0)
            {
                MessageBox.Show("Last consultation not found");
                return;
            }

            var cons = new ConsultationForm(expertSystem.ExplanationComponent.Explanation, expertSystem.WorkingMemory.Variables);
            Visible = false;
            cons.ShowDialog();
            Visible = true;
        }

        #endregion
    }
}