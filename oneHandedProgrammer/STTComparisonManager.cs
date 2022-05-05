using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneHandedProgrammer
{
    [Serializable]
    public class STTComparisonManager
    {
        public List<ComparisonSTT> _listManager;

        public STTComparisonManager()
        {
            _listManager = new List<ComparisonSTT>();
        }

        public void addASTTComparison(string entendu, string converti)
        {
            _listManager.Add(new ComparisonSTT(entendu, converti));
        }
        public ComparisonSTT convertSTT(string entendu)
        {
            foreach(ComparisonSTT compared in _listManager)
            {
                if (entendu.Contains(compared.Entendu))
                {
                    return compared;
                }
            }
            return new ComparisonSTT(entendu, string.Empty);
        }
    }
}
