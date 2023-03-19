using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class WorkingMemory
    {
        public List<ValuedVariable> Variables { get; set; }

        public WorkingMemory()
        {
            Variables = new List<ValuedVariable>();
        }
    }
}
