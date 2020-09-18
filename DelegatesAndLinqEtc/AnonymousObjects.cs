using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public class AnonymousObjects
    {
        [Fact]
        public void UsingThem()
        {
            //movie is read only, cant change
            var movie = new { Title = "Jaws", Director = "Speilburg", YearReleased = 1977 };
            Assert.Equal("Jaws", movie.Title);

            var manager = GetManager();
            //No properties
            var numbers = new List<int> { 1, 2, 3, 4 };
            var numbersDoubledAndTurnedIntoString = numbers.Select(n => new { Original = n, Doubled = (n * 2).ToString() }).ToList();

            Assert.Equal("2", numbersDoubledAndTurnedIntoString[0].Doubled);
            Assert.Equal(1, numbersDoubledAndTurnedIntoString[0].Original);
            Assert.Equal("4", numbersDoubledAndTurnedIntoString[1].Doubled);
            Assert.Equal(2, numbersDoubledAndTurnedIntoString[1].Original);

        }
        public object GetManager()
        {
            return new { Name = "Karen" };
        }
    }
}
