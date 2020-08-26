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
        [Fact]
        public void WithdrawTest2()
        {
            decimal balance = 20;
            decimal withdraw = (-30);

            bool result = Program.Withdraw(balance, withdraw) == 50;

            Assert.False(result); 
        }
        [Fact]
        public void DepositTest2()
        {
            decimal balance = 20;
            decimal deposit = (-30);

            bool result = Program.Withdraw(balance, deposit) == -10;

            Assert.False(result);
        }
    }
}
