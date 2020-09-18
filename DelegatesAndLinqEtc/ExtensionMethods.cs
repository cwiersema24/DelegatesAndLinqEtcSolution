using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DelegatesAndLinqEtc
{
    public class ExtensionMethods
    {
        ITestOutputHelper _outputHelper;

        public ExtensionMethods(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
       public void THeCase()
        {
            int someNumber = 12;

            if (someNumber.IsEven())
            {

            }
            else
            {

            }


            var nextWeek = 7.DaysFromNow();

            var friends = new List<string> { "Katelyn", "Lindsay", "Hannah", "Shelby", "Tim" };
            var threeLetterNames = friends.Where(x => x.Length == 3);
            friends.Add("Max");
            foreach(var person in threeLetterNames)
            {
                _outputHelper.WriteLine(person);
            }

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evens = numbers.Where(Utils.IsEven).ToList();

            Assert.Equal(2, evens[0]);

            var five = numbers.Single(n => n == 5);
            Assert.Equal(5, five);

            var david = friends.SingleOrDefault(f => f == "David");

            Assert.Null(david);
        }

    }
}
