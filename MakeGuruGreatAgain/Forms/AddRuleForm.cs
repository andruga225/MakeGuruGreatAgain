using MakeGuruGreatAgain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeGuruGreatAgain.Forms
{
    public partial class AddRuleForm : Form
    {
        public string ruleName = "";
        public List<Statement> premise = new List<Statement>();
        public List<Statement> conclusion = new List<Statement>();
        public string reason;
        private List<Model.Rule> kbRules = new List<Model.Rule>();
        public List<Variable> variables = new List<Variable>();
        public List<Domain> domains = new List<Domain>();
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public AddRuleForm(List<Model.Rule> kbRules, List<Variable> variables, List<Domain> domains)
        {
            InitializeComponent();
            this.kbRules = kbRules;
            this.variables = variables;
            this.domains = domains;
            tbRuleName.Text = $"Rule{kbRules.Count + 1}";
            this.Name = $"New rule";
        }

        public AddRuleForm(string ruleName, List<Statement> premise, List<Statement> conclusion, string reason,
            List<Model.Rule> kbRules, List<Domain> domains, List<Variable> variables)
        {
            InitializeComponent();

            tbRuleName.Text = ruleName;
            lbxPremise.Items.AddRange(premise.ToArray());
            lbxConclusion.Items.AddRange(conclusion.ToArray());
            tbReason.Text = reason;

            this.ruleName = ruleName;
            this.premise = premise;
            this.conclusion = conclusion;
            this.reason = reason;
            this.kbRules = kbRules;
            this.variables = variables;
            this.domains = domains;
            this.Name = ruleName;
        }

        private void btnAddPremise_Click(object sender, EventArgs e)
        {
            var premise = new AddStatementForm(variables, domains);
            premise.ShowDialog();

            if(premise.DialogResult == DialogResult.OK)
            {
                if(this.premise.FindIndex(pr => pr.Variable.Name == premise.variable.Name && pr.Value.Value == premise.domainVal.Value) != -1)
                {
                    MessageBox.Show("This statement already exists in premise!");
                    return;
                }

                this.premise.Add(new Statement(premise.variable, premise.domainVal));

                lbxPremise.Items.Clear();
                lbxPremise.Items.AddRange(this.premise.ToArray());
                lbxPremise.ClearSelected();
            }

            variables = premise.variables;
            domains = premise.domains;

        }

        private void btnEditPremise_Click(object sender, EventArgs e)
        {
            if (lbxPremise.SelectedIndex != -1)
            {
                var premise = new AddStatementForm(this.premise[lbxPremise.SelectedIndex].Variable, this.premise[lbxPremise.SelectedIndex].Value,
                    variables, domains);

                premise.ShowDialog();

                if (premise.DialogResult == DialogResult.OK)
                {
                    if (this.premise.FindIndex(pr => pr.Variable.Name == premise.variable.Name && pr.Value.Value == premise.domainVal.Value) != -1)
                    {
                        MessageBox.Show("This statement already exists in premise!");
                        return;
                    }

                    this.premise[lbxPremise.SelectedIndex].Variable = premise.variable;
                    this.premise[lbxPremise.SelectedIndex].Value = premise.domainVal;

                    lbxPremise.Items.Clear();
                    lbxPremise.Items.AddRange(this.premise.ToArray());
                    lbxPremise.ClearSelected();
                }

                variables = premise.variables;
                domains = premise.domains;
            }
        }

        private void btnDeletePremise_Click(object sender, EventArgs e)
        {
            if(lbxPremise.SelectedIndex != -1)
            {
                premise.RemoveAt(lbxPremise.SelectedIndex);
                lbxPremise.Items.RemoveAt(lbxPremise.SelectedIndex);

                lbxPremise.ClearSelected();
            }
        }

        private void btnAddConclusion_Click(object sender, EventArgs e)
        {
            var conclusion = new AddStatementForm(variables.FindAll(var => var.Type == VariableType.Output || var.Type == VariableType.RequestOutput), domains);
            conclusion.ShowDialog();

            if (conclusion.DialogResult == DialogResult.OK)
            {
                if(conclusion.variable.Type == VariableType.Requested)
                {
                    MessageBox.Show("Conclusion can't include requested variable!");
                    return;
                }

                if (this.conclusion.FindIndex(c => c.Variable.Name == conclusion.variable.Name && c.Value.Value == conclusion.domainVal.Value) != -1)
                {
                    MessageBox.Show("This statement already exists in conclusion!");
                    return;
                }

                this.conclusion.Add(new Statement(conclusion.variable, conclusion.domainVal));
                lbxConclusion.Items.Clear();
                lbxConclusion.Items.AddRange(this.conclusion.ToArray());
                lbxConclusion.ClearSelected();
            }

            conclusion.variables.ForEach(var =>
            {
                if (!variables.Contains(var))
                {
                    variables.Add(var);
                }
            });

            conclusion.domains.ForEach(dm =>
            {
                if (!domains.Contains(dm))
                    domains.Add(dm);
            });
        }

        private void btnEditConclusion_Click(object sender, EventArgs e)
        {
            if (lbxConclusion.SelectedIndex != -1)
            {
                var conclusion = new AddStatementForm(this.conclusion[lbxConclusion.SelectedIndex].Variable, this.conclusion[lbxConclusion.SelectedIndex].Value,
                    variables.FindAll(var => var.Type == VariableType.Output || var.Type == VariableType.RequestOutput), domains);

                conclusion.ShowDialog();

                if (conclusion.DialogResult == DialogResult.OK)
                {
                    if (conclusion.variable.Type == VariableType.Requested)
                    {
                        MessageBox.Show("Conclusion can't include requested variable!");
                        return;
                    }

                    if (this.conclusion.FindIndex(c => c.Variable.Name == conclusion.variable.Name && c.Value.Value == conclusion.domainVal.Value) != -1)
                    {
                        MessageBox.Show("This statement already exists in conclusion!");
                        return;
                    }

                    this.conclusion[lbxConclusion.SelectedIndex].Variable = conclusion.variable;
                    this.conclusion[lbxConclusion.SelectedIndex].Value = conclusion.domainVal;

                    lbxConclusion.Items.Clear();
                    lbxConclusion.Items.AddRange(this.conclusion.ToArray());
                    lbxConclusion.ClearSelected();
                }

                conclusion.variables.ForEach(var =>
                {
                    if (!variables.Contains(var))
                    {
                        variables.Add(var);
                    }
                });

                conclusion.domains.ForEach(dm =>
                {
                    if (!domains.Contains(dm))
                        domains.Add(dm);
                });
            }
        }

        private void btnDeleteConclusion_Click(object sender, EventArgs e)
        {
            if (lbxConclusion.SelectedIndex != -1)
            {
                conclusion.RemoveAt(lbxConclusion.SelectedIndex);
                lbxConclusion.Items.RemoveAt(lbxConclusion.SelectedIndex);

                lbxConclusion.ClearSelected();
            }
        }

        private void btnRuleOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbRuleName.Text))
            {
                MessageBox.Show("Input a rule name!");
                return;
            }

            if(ruleName != tbRuleName.Text && kbRules.FindAll(rule => rule.Name == tbRuleName.Text).Count > 0)
            {
                MessageBox.Show("Rule with this name already exists!");
                return;
            }

            if(premise.Count == 0)
            {
                MessageBox.Show("Rule should have a premise!");
                return;
            }

            if(conclusion.Count== 0)
            {
                MessageBox.Show("Rule should have a conclusion!");
                return;
            }

            DialogResult = DialogResult.OK;
            
            ruleName = tbRuleName.Text;
            reason = tbReason.Text;

            Close();
        }

        private void btnRuleCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }



        public void lbxPremiseMoveItem(int direction)
        {
            // Checking selected item
            if (lbxPremise.SelectedItem == null || lbxPremise.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lbxPremise.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lbxPremise.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lbxPremise.SelectedItem;

            // Removing removable element
            lbxPremise.Items.Remove(selected);
            // Insert it in new position
            lbxPremise.Items.Insert(newIndex, selected);
            // Restore selection
            lbxPremise.SetSelected(newIndex, true);
        }

        private void lbxPremise_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = lbxPremise.DoDragDrop(
                    lbxPremise.Items[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void lbxPremise_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = lbxPremise.IndexFromPoint(e.X, e.Y);
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

        private void lbxPremise_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbxPremise_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = lbxPremise.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                lbxPremise.IndexFromPoint(clientPoint.X, clientPoint.Y);

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                var rowToMove = lbxPremise.SelectedItems[0];
                lbxPremise.Items.RemoveAt(rowIndexFromMouseDown);
                try
                {
                    lbxPremise.Items.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    var t = premise[rowIndexFromMouseDown];
                    premise[rowIndexFromMouseDown] = premise[rowIndexOfItemUnderMouseToDrop];
                    premise[rowIndexOfItemUnderMouseToDrop] = t;
                }
                catch
                {
                    lbxPremise.Items.Insert(lbxPremise.Items.Count, rowToMove);
                    var t = premise[rowIndexFromMouseDown];
                    premise[rowIndexFromMouseDown] = premise[lbxPremise.Items.Count - 1];
                    premise[lbxPremise.Items.Count - 1] = t;
                }

            }
        }
    }
}
