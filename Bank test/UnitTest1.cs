using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// Manvir Singh C0730069
// Harmanjot Singh C0727172
namespace Bank_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //Arrange

        double beginningBalance = 11.99;

        double debitAmount = 4.55;

        double expected = 7.44;

        BankAccount account = new BankAccount("Mr. Manvir Singh \nMr. Harmanjot Singh", beginningBalance);



        //Act

        account.Debit(debitAmount);



            //Assert

            double actual = account.Balance;

        Assert.AreEqual(expected, actual, 0.0001, "Account nt debited correctly");

    }
}
