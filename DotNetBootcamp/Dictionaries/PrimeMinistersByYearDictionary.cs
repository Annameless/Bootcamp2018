using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dictionaries
{
    public class PrimeMinistersByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
		protected override int GetKeyForItem(PrimeMinister item)
		{
            return item.YearElected;
		}
	}
}
