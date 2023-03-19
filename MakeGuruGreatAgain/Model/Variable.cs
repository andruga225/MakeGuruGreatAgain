using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    public enum VariableType {Requested, Output, RequestOutput};

    [Serializable]
    public class Variable
    {
        public string Name { get; set; }
        public VariableType Type { get; set; }
        public Domain Domain { get; set; }
        public string Question { get; set; }

        public Variable(string name, VariableType type, Domain domain, string question)
        {
            Name = name;
            Type = type;
            Domain = domain;
            Question = question;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
