using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class ExpertSystem
    {
        public KnowledgeBase KnowledgeBase { get; set; }
        public ExplanationComponent ExplanationComponent { get; set; }
        public WorkingMemory WorkingMemory { get; set; }

        public ExpertSystem()
        {
            KnowledgeBase = new KnowledgeBase();
            ExplanationComponent = new ExplanationComponent();
            WorkingMemory = new WorkingMemory();
        }
    }
}
