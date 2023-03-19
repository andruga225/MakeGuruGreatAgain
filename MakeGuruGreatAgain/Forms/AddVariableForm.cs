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
    public partial class AddVariableForm : Form
    {
        public string variableName = "";
        public Domain variableDomain;
        public VariableType variableType;
        public string variableQuestion;
        public List<Domain> domains = new List<Domain>();
        private List<Variable> kbVariables = new List<Variable>();

        public AddVariableForm(List<Domain> domains, List<Variable> knowladgeBaseVariables)
        {
            InitializeComponent();

            cbVariableDomain.Items.AddRange(domains.ToArray());
            this.domains = domains;

            groupBox4.Visible = false;
            kbVariables = knowladgeBaseVariables;
            tbVariableName.Text = $"Variable{knowladgeBaseVariables.Count + 1}";
            this.Name = "New variable";
        }

        public AddVariableForm(string variableName, VariableType variableType, Domain variableDomain, string variableQuestion, List<Domain> domains, List<Variable> knowladgeBaseVariables)
        {
            InitializeComponent();

            tbVariableName.Text = variableName;

            cbVariableDomain.Items.AddRange(domains.ToArray());
            cbVariableDomain.SelectedIndex = domains.FindIndex(domain => domain.Name == variableDomain.Name);

            tbQuestion.Text = variableQuestion;

            switch (variableType)
            {
                case VariableType.Requested:
                    rbtnRequested.Checked = true;
                    break;
                case VariableType.Output:
                    rbtnOutput.Checked = true;
                    break;
                case VariableType.RequestOutput:
                    rbtnReqOut.Checked = true;
                    break;
            }

            this.domains = domains;
            kbVariables = knowladgeBaseVariables;
            this.variableName = variableName;
            this.variableDomain = variableDomain;
            this.variableQuestion = variableQuestion;
            this.variableType = variableType;
            this.Name = variableName;
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            var newDomain = new AddDomainForm(domains);

            newDomain.ShowDialog();

            if (newDomain.DialogResult == DialogResult.OK)
            {
                domains.Add(new Domain(newDomain.domainName, newDomain.domainValues));

                cbVariableDomain.Items.Clear();
                cbVariableDomain.Items.AddRange(domains.ToArray());
                cbVariableDomain.SelectedIndex = domains.FindIndex(d => d.Name == newDomain.domainName);
            }

        }

        private void variableTypeChanged(object sender, EventArgs e)
        {
            if(rbtnRequested.Checked || rbtnReqOut.Checked)
            {
                groupBox4.Visible = true;
                tbQuestion.Text = tbVariableName.Text + "?";
            }
            else
            {
                groupBox4.Visible = false;
                tbQuestion.Text = string.Empty;
            }
        }

        private void btnVariableCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnVariableOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbVariableName.Text))
            {
                
                MessageBox.Show("Input a variable name!");
                return;
            }

            if(variableName != tbVariableName.Text && kbVariables.FindAll(var => var.Name == tbVariableName.Text).Count > 0)
            {
                MessageBox.Show("Variable with this name already exists!");
                return;
            }

            if(cbVariableDomain.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a variable domain!");
                return;
            }

            if(!rbtnOutput.Checked && !rbtnReqOut.Checked && !rbtnRequested.Checked)
            {
                MessageBox.Show("Choose a variable type!");
                return;
            }

            if((rbtnRequested.Checked || rbtnReqOut.Checked) && string.IsNullOrWhiteSpace(tbQuestion.Text))
            {
                MessageBox.Show("Input a question!");
                return;
            }

            variableName = tbVariableName.Text;
            variableDomain = domains.First(dm => dm.Name == cbVariableDomain.SelectedItem.ToString());

            if (rbtnRequested.Checked)
                variableType = VariableType.Requested;

            if (rbtnReqOut.Checked)
                variableType = VariableType.RequestOutput;

            if (rbtnOutput.Checked)
                variableType = VariableType.Output;

            variableQuestion = tbQuestion.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
