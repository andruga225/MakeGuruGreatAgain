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
    public partial class AddStatementForm : Form
    {
        public List<Variable> variables = new List<Variable>();
        public List<Domain> domains = new List<Domain>();
        public Variable variable;
        public DomainValue domainVal;


        public AddStatementForm()
        {
            InitializeComponent();
        }

        public AddStatementForm(Variable variable, DomainValue domainValue, List<Variable> variables, List<Domain> domain)
        {
            InitializeComponent();

            this.variables = variables;
            domains = domain;
            this.variable = variable;

            cbxStatementVariable.Items.AddRange(variables.ToArray());
            cbxStatementVariable.SelectedIndex = variables.FindIndex(var => variable.Name == var.Name);

            //cbxStatementValue.Items.AddRange(domain.First(d => d.Name == variable.Domain.Name).Values.ToArray());
            //cbxStatementValue.SelectedIndex = domain.First(d => d.Name == variable.Domain.Name).Values.FindIndex(v => v.Value == domainValue.Value);
        }

        public AddStatementForm(List<Variable> variables, List<Domain> domains)
        {
            InitializeComponent();

            this.variables = variables;
            this.domains = domains;

            cbxStatementVariable.Items.AddRange(variables.ToArray());
        }

        private void btnStatementSave_Click(object sender, EventArgs e)
        {
            if (cbxStatementValue.SelectedIndex > -1 && cbxStatementVariable.SelectedIndex > -1)
            {
                variable = variables[cbxStatementVariable.SelectedIndex];
                domainVal = domains.FirstOrDefault(d => d.Name == variable.Domain.Name).Values.FirstOrDefault(val => val.Value == cbxStatementValue.SelectedItem.ToString());

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnStatementCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbxStatementVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxStatementValue.Items.Clear();

            variable = variables[cbxStatementVariable.SelectedIndex];

            cbxStatementValue.Items.AddRange(domains.First(d => d.Name == variable.Domain.Name).Values.ToArray());
            cbxStatementValue.SelectedIndex = 0;
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            var variable = new AddVariableForm(domains, variables);

            variable.ShowDialog();

            if(variable.DialogResult == DialogResult.OK)
            {
                variables.Add(new Variable(variable.variableName, variable.variableType, variable.variableDomain, variable.variableQuestion));
                domains = variable.domains;

                cbxStatementVariable.Items.Clear();
                cbxStatementVariable.Items.AddRange(variables.ToArray());
                cbxStatementVariable.SelectedIndex = variables.FindIndex(var => var.Name == variable.variableName);
            }
        }
    }
}
