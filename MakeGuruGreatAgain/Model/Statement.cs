using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class Statement
    {
        public Variable Variable { get; set; }
        public DomainValue Value { get; set; }

        public Statement(Variable variable, DomainValue value)
        {
            Variable = variable;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Variable} = {Value}";
        }
    }

}
