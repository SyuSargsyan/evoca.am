namespace evoca.am
{
    internal class Tests : SetUp
    { 

        [Test]
        public void loanEarlyRepaymentFunctionalityTest()
        {
            methods.loanEarlyRepaymentFunctionality();
        }
        [Test]
        public void loanRegularRepaymentFunctionalityTest()
        {
            methods.loanRefularRepaymentFunctionality();
        }
        [Test]
        public void AccountReplenishmentFunctionalityTest()
        {
            methods.AccountReplenishmentFunctionality();
        }
        [Test]
        public void CardRepaymentFunctionalityTest()
        {
            methods.CardRelenishementFunctionality();
        }
    }
}