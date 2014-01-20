using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch8_Ducks
{
    public class DuckComparer : IComparer<Duck>
    {
        public DuckComparer(SortCriteria sortCriterion)
        {
            SortCriterion = sortCriterion;
        }

        public enum SortCriteria
        {
            SizeThenKind,
            KindThenSize,
        }

        public SortCriteria SortCriterion { get; set; }

        public int Compare(Duck x, Duck y)
        {
            if (SortCriterion == SortCriteria.SizeThenKind)
                return x.CompareTo(y);
            else
            {
                int temp = string.CompareOrdinal(x.Kind.ToString(), y.Kind.ToString());
                if (temp == 0)
                {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
                }
                else
                    return temp;
            }
        }
    }
}