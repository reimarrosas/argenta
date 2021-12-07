using FinalArgentaFrontend.DTO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FinalArgentaFrontend.Utils
{
    public class EntryComparer : IEqualityComparer<InvestmentEntryDTO>
    {
        public bool Equals(InvestmentEntryDTO? x, InvestmentEntryDTO? y)
        {
            if (x == null || y == null)
            {
                return false;
            } else
            {
                return x.Ticker.Equals(y.Ticker);
            }
        }

        public int GetHashCode([DisallowNull] InvestmentEntryDTO obj)
        {
            return obj.Ticker.GetHashCode();
        }
    }
}
