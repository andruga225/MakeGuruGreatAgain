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
    public partial class QuestionForm : Form
    {
        public DomainValue domainValue;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(Variable var)
        {
            InitializeComponent();

            lbVariableQuestion.Text = var.Question;
            cbxVariableValue.Items.AddRange(var.Domain.Values.ToArray());
            cbxVariableValue.SelectedIndex = 0;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            domainValue = (DomainValue)cbxVariableValue.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
