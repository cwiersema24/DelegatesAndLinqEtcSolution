﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DelegatesAndLinqEtc
{
    public class Enumerables
    {
        ITestOutputHelper _output;

        public Enumerables(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void EnumerablesAreThingsThatYOuCanEnumerate()
        {
            var names = new List<string> { "Cooper", "Harry", "Leland", "Sarah" };
            foreach(var name in names)
            {
                _output.WriteLine(name);
            }

            var message = "That gum you like is going to come back into style";

            foreach(var letter in message)
            {
                _output.WriteLine(letter.ToString());
            }
        }
        [Fact]
        public void GettingTheNUmbersA()
        {
            var ng = new NUmberGenorator();
            var sw = new Stopwatch();
            sw.Start();
            var numbers = ng.GetNumbersOneToOneHundred();
            foreach(var n in numbers)
            {
                if(n == 10)
                {
                    break;
                }
            }
            sw.Stop();
            _output.WriteLine($"That took {sw.ElapsedMilliseconds}ms");
        }
        [Fact]
        public void EnumerateMovies()
        {
            var ng = new NUmberGenorator();
            foreach(var movie in ng.FavMovies())
            {
                _output.WriteLine(movie);
            }
        }
    }
}
