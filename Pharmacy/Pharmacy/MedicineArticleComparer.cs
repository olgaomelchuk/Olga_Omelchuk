using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class MedicineArticleComparer : IComparer<Medicine>
    {
        public int Compare(Medicine x, Medicine y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (y == null) return 1;
            if (x == null) return -1;

            return string.Compare(x.Article, y.Article, StringComparison.Ordinal);
        }
    }
}
