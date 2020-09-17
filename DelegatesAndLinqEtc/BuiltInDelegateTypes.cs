﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DelegatesAndLinqEtc
{
    public class BuiltInDelegateTypes
    {
        [Fact]
        public void UsingActions()
        {
            //delegate type that can refer to a method that return void and takes 0 to 16 arguments

            Action thingy;
            thingy = () => Console.Write("Hello, World");
            thingy();
            thingy = () => Console.Write("Goodbuy");
            thingy();

            Action<string, int> thingy2 = (message, times) =>
             {
                 for (var t = 0; t < times; t++)
                 {
                     Console.WriteLine(message);
                 }
             };

            thingy2("Wow Bob Wow", 13);

        }
        [Fact]
        public void Funcs()
        {
            //delegates that return soemthing and take zero or more (<16) arguments
            //last is return type

            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(4, mathOp(2, 2));

            mathOp = (a, b) => a * b;
            Assert.Equal(9, mathOp(3, 3));

            Func<int, bool> isEven = (x) => x % 2 == 0;
            Assert.True(isEven(4));
            Assert.False(isEven(5));

            var calculator = new Dictionary<char, Func<int, int, int>>
            {
                {'+', (a,b)=> a+b },
                 {'-', (a,b)=> a-b },
                  {'*', (a,b)=> a*b },
                   {'/', (a,b)=> a/b }
            };

            var result = calculator['+'](2, 5);
            Assert.Equal(7, result);
        }
        [Fact]
        public void Predicate()
        {
            Predicate<string> doYouLike;
            doYouLike = (what) => what == "pizza" ? true : false;



            Assert.True(doYouLike("pizza"));
            Assert.False(doYouLike("literally anythign else"));
        }
    }
}
