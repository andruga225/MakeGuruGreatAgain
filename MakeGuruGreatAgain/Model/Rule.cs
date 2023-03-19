using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class Rule
    {
        public string Name { get; set; }
        public List<Statement> Premise { get; set; }
        public List<Statement> Conclusion { get; set; }
        public string Reason { get; set; }

        public Rule(string name, List<Statement> premise, List<Statement> conclusion, string reason)
        {
            Name = name;
            Premise = premise;
            Conclusion = conclusion;
            Reason = reason;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public string RuleDescription()
        {
            return $"IF " + string.Join(" AND ", Premise) + " THEN " + string.Join(" AND ", Conclusion);
        }
    }
}
