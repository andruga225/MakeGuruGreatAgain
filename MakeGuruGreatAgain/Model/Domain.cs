using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; set; }

        public Domain(string name, List<DomainValue> values)
        {
            Name = name;
            Values = values;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
