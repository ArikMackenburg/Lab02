using Lab;
using System;
using Xunit;

namespace Lab.Test
{
    public class Test
    {
        [Fact]
        public void ViewBalanceTest()
        {
            decimal balance = Program.Balance;

            decimal result = Program.ViewBalance(balance);

            Assert.Equal(result, Program.Balance);

            
        }

        [Theory]
        [InlineData(30, 20, 10)]
        [InlineData(20, 30, 0)]
        [InlineData(30,-20,30)]
        public void WithdrawTest(decimal balance, decimal withraw, decimal expect)
        {
            decimal result = Program.Withdraw(balance, withraw);
            Assert.Equal(result, expect);
        }

        [Theory]
        [InlineData(30, 80, 110)]
        [InlineData(20, 30, 50)]
        [InlineData(30, -20, 30)]
        public void DepositTest(decimal balance, decimal deposit, decimal expect)
        {
            decimal result = Program.Deposit(balance, deposit);
            Assert.Equal(result, expect);
        }
    }
}
