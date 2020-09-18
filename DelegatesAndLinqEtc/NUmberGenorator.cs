using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesAndLinqEtc
{
    public class NUmberGenorator
    {
        public IEnumerable<int> GetNumbersOneToOneHundred()
        {
            
            for (var n=1; n<101; n++)
            {
                Thread.Sleep(100);
                yield return n;
            }
            
        }

        public IEnumerable<string> FavMovies()
        {
            yield return "Shadows";
            yield return "Movie 2";
            yield return "Movie 3";
            yield return "Movie 4";
        }
    }
}
