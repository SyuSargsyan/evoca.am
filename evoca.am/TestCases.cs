namespace evoca.am
{
    internal class Tests : SetUp
    { 
        //EvocaPayment
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
        public void CardReplenishementFunctionalityTest()
        {
            methods.CardRelenishementFunctionality();
        }
        //C2C transfers
        [Test]
        public void CardToCardTransactionFunctionalityTest()
        {
            methods.CardToCardTransactionFunctionality();
        }
        //Utility payments
        [Test]
        public void viveMobilePaymentFunctionalityTest()
        {
            methods.ViveMobilePaymentFunctionality();
        }
        [Test]
        public void uComMobilePaymentFunctionalityTest()
        {
            methods.UComMobilePaymentFunctionality();
        }
        [Test]
        public void TeamMobilePaymentFunctionalityTest()
        {
            methods.TeamMobilePaymentFunctionality();
        }
    }
}