using System;
using Xunit;
using api.Controllers;
using System.Linq;

namespace tests
{
    public class RanageTest
    {
        [Fact] 
        public void CountShouldControlNumberOfResults()
        {
            var range = new Range {  Count = 3 };
            var generated = range.Of(() => "");

            Assert.Equal(3, generated.Count());

        }
    }
}
