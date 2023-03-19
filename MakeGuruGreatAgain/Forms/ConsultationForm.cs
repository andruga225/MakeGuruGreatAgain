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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MakeGuruGreatAgain.Forms
{
    public partial class ConsultationForm : Form
    {
        private Variable goal;
        private List<Model.Rule> rules = new List<Model.Rule>();
        public List<ValuedVariable> valuedVariables = new List<ValuedVariable>();
        public TreeNode rootNode;

        public ConsultationForm(List<Variable> variables, List<Model.Rule> rules)
        {
            InitializeComponent();
            this.Visible = false;
            this.rules = rules;

            var goalForm = new NewGoalForm(variables);
            goalForm.ShowDialog();

            if (goalForm.DialogResult == DialogResult.OK)
            {
                goal = goalForm.goal;
                trvRules.Nodes.Add(new TreeNode(goal.Name));
                MLV(goal, trvRules.Nodes[0]);
                if (valuedVariables.FindIndex(v => v.Variable.Name == goal.Name) != -1)
                    trvRules.Nodes[0].Text = $"Goal: {goal.Name} = {valuedVariables.First(v => v.Variable.Name == goal.Name).Value}";
                else
                    MessageBox.Show("Consultation finished with error!");

                foreach (var valuedVariable in valuedVariables)
                {
                    dgvValuedVariables.Rows.Add(valuedVariable.Variable.Name, valuedVariable.Value.Value);
                }
            }
        }

        public ConsultationForm(TreeNode root, List<ValuedVariable> valuedVariables)
        {
            InitializeComponent();

            trvRules.Nodes.Clear();
            trvRules.Nodes.Add(new TreeNode());
            trvRules.Nodes[0] = (TreeNode)root.Clone();

            foreach (var valuedVariable in valuedVariables)
            {
                dgvValuedVariables.Rows.Add(valuedVariable.Variable.Name, valuedVariable.Value.Value);
            }
        }

        private void MLV(Variable goal, TreeNode nodeToAddTo)
        {
            if (goal.Type == VariableType.Requested)
            {
                var ques = new QuestionForm(goal);
                ques.ShowDialog();

                if (ques.DialogResult == DialogResult.OK)
                {
                    nodeToAddTo.Nodes.Insert(0, $"{goal.Name} = {ques.domainValue.Value} (get from user)");
                    nodeToAddTo.Text = $"Goal: {goal.Name} = {ques.domainValue.Value}";
                    valuedVariables.Add(new ValuedVariable { Variable = goal, Value = ques.domainValue });
                }

                return;
            }

            foreach (var rule in rules)
            {
                if (valuedVariables.FindIndex(var => var.Variable.Name == goal.Name) != -1)
                {
                    return;
                }

                if (rule.Conclusion.FindIndex(conc => conc.Variable.Name == goal.Name) != -1)
                {
                    bool isValued = true;

                    foreach (var prem in rule.Premise)
                    {
                        int varIndex = valuedVariables.FindIndex(var => var.Variable.Name == prem.Variable.Name);

                        if (varIndex == -1)
                        {
                            TreeNode newNode = new TreeNode(prem.Variable.Name);
                            nodeToAddTo.Nodes.Add(newNode);
                            MLV(prem.Variable, newNode);
                        }

                        varIndex = valuedVariables.FindIndex(var => var.Variable.Name == prem.Variable.Name);

                        if (varIndex != -1)
                        {
                            if (prem.Value.Value != valuedVariables[varIndex].Value.Value)
                            {
                                isValued = false;
                                break;
                            }
                        }
                        else
                        {
                            isValued = false;
                            break;
                        }

                    }

                    if (isValued)
                    {
                        valuedVariables.Add(new ValuedVariable { Variable = goal, Value = rule.Conclusion.First(conc => conc.Variable.Name == goal.Name).Value });
                        nodeToAddTo.Nodes.Insert(0, new TreeNode($"{rule.Name}: {rule.RuleDescription()}"));
                        nodeToAddTo.Text = $"Goal: {goal.Name} = {valuedVariables.First(var => var.Variable.Name == goal.Name).Value}";
                        return;
                    }
                }
            }

            if(goal.Type == VariableType.RequestOutput && valuedVariables.FindIndex(var => var.Variable.Name == goal.Name) == -1)
            {
                var ques = new QuestionForm(goal);
                ques.ShowDialog();

                if (ques.DialogResult == DialogResult.OK)
                {
                    nodeToAddTo.Nodes.Insert(0, $"{goal.Name} = {ques.domainValue.Value} (get from user)");
                    nodeToAddTo.Text = $"Goal: {goal.Name} = {ques.domainValue.Value}";
                    valuedVariables.Add(new ValuedVariable { Variable = goal, Value = ques.domainValue });
                }

                return;
            }
        }

        private void ConsultationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rootNode = trvRules.Nodes[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            trvRules.ExpandAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            trvRules.CollapseAll();
        }
    }
}
