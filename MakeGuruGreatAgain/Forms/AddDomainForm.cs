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
    public partial class AddDomainForm : Form
    {
        public string domainName = "";
        public List<DomainValue> domainValues = new List<DomainValue>();
        private List<Domain> kbDomains = new List<Domain>();

        public AddDomainForm(List<Domain> knowladgeBaseDomains)
        {
            InitializeComponent();

            kbDomains = knowladgeBaseDomains;
            this.Name = "New domain";
        }

        public AddDomainForm(string domainName, List<DomainValue> domainValues, List<Domain> knowladgeBaseDomains)
        {
            InitializeComponent();

            tbDomainName.Text = domainName;
            lbxDomainValues.Items.AddRange(domainValues.ToArray());

            this.domainValues = domainValues;
            kbDomains = knowladgeBaseDomains;
            this.domainName = domainName;
            this.domainValues = domainValues;
            this.Name = domainName;
        }

        private void btnAddDomainValue_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbDomainValue.Text))
            {

                if(domainValues.FindIndex(dm => dm.Value == tbDomainValue.Text) != -1)
                {
                    MessageBox.Show("Domain value already exists in this domain!");
                    return;
                }

                DomainValue domainValue = new DomainValue(tbDomainValue.Text);
                domainValues.Add(domainValue);
                lbxDomainValues.Items.Add(domainValue);
                tbDomainValue.Text = "";
            }
            else
            {
                MessageBox.Show("Domain value is empty!");
            }
        }

        private void btnEditDomainValue_Click(object sender, EventArgs e)
        {
            if(lbxDomainValues.SelectedIndex > -1)
            {
                if(!string.IsNullOrWhiteSpace(tbDomainValue.Text))
                {

                    if (domainValues.FindIndex(dm => dm.Value == tbDomainValue.Text) != -1
                        && domainValues.FindIndex(dm => dm.Value == tbDomainValue.Text) != lbxDomainValues.SelectedIndex)
                    {
                        MessageBox.Show("Domain value already exists in this domain!");
                        return;
                    }

                    domainValues[lbxDomainValues.SelectedIndex].Value = tbDomainValue.Text;
                    lbxDomainValues.Items.Clear();
                    lbxDomainValues.Items.AddRange(domainValues.ToArray());
                    lbxDomainValues.ClearSelected();
                    tbDomainValue.Text = "";
                }
                else
                {
                    MessageBox.Show("Domain value is empty!");
                }
            }
            else
            {
                MessageBox.Show("Choose a domain value to edit!");
            }
        }

        private void lbxDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxDomainValues.SelectedIndex > -1)
            {
                tbDomainValue.Text = domainValues[lbxDomainValues.SelectedIndex].Value;
            }
        }

        private void btnDeleteDomainValue_Click(object sender, EventArgs e)
        {
            if(lbxDomainValues.SelectedIndex > -1)
            {
                domainValues.Remove(domainValues[lbxDomainValues.SelectedIndex]);
                lbxDomainValues.Items.Clear();
                lbxDomainValues.Items.AddRange(domainValues.ToArray());
                tbDomainValue.Text = "";
            }
            else
            {
                MessageBox.Show("Choose a domain value to delete!");
            }
        }

        private void lbxDomainValues_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                lbxDomainValues.ClearSelected();
                tbDomainValue.Text = "";
            }
        }

        private void btnDomainCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnDomainOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbDomainName.Text))
            {
                MessageBox.Show("Input a domain name!");
                return;
            }

            if (domainName != tbDomainName.Text && kbDomains.FindAll(dm => dm.Name == tbDomainName.Text).Count > 0)
            {
                MessageBox.Show("Domain with this name already exist!");
                return;
            }

            if (lbxDomainValues.Items.Count == 0)
            {
                MessageBox.Show("Add a domain values!");
                return;
            }

            domainName = tbDomainName.Text;
            
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
