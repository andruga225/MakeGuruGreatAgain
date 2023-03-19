using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeGuruGreatAgain.Model
{
    [Serializable]
    public class ExplanationComponent
    {
        public TreeNode Explanation { get; set; }

        public ExplanationComponent()
        {
            Explanation = new TreeNode();
        }
    }
}
