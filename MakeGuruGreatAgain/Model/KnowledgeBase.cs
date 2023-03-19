using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class KnowledgeBase
    {
        public List<Rule> Rules { get; set; }
        public List<Variable> Variables { get; set; }
        public List<Domain> Domains { get; set; }

        public KnowledgeBase()
        {
            Rules = new List<Rule>();
            Variables = new List<Variable>();
            Domains = new List<Domain>();
        }
    }
}
