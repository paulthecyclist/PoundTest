using System;
using Xunit;
using Business;

namespace Tests
{
    public class FormatterTests
    {
        private Formatter _formatter;

        public FormatterTests()
        {
            _formatter = new Formatter();
        }

        [Fact]
        public void GivenItIsFreeSomeDayWhenFormattedExpectPriceToBeZero()
        {
            var secondFeb = new DateTime(2020, 2, 10);
            const string expected = "The price on 10/02/2020 is £0.00";

            var actual = _formatter.PrintReceipt(0, secondFeb);

            Assert.Equal(expected, actual);
        }
    }
}
