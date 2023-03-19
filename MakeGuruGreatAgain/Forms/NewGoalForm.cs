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
    public partial class NewGoalForm : Form
    {
        public Variable goal;

        public NewGoalForm()
        {
            InitializeComponent();
        }

        public NewGoalForm(List<Variable> variables)
        {
            InitializeComponent();
            cbxGoal.Items.AddRange(variables.ToArray());

            if(cbxGoal.Items.Count == 0 )
            {
                MessageBox.Show("Variable list is empty!");
                Close();
            }

            cbxGoal.SelectedIndex = cbxGoal.Items.Count - 1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(cbxGoal.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a consultation goal!");
                return;
            }

            goal = (Variable)cbxGoal.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
