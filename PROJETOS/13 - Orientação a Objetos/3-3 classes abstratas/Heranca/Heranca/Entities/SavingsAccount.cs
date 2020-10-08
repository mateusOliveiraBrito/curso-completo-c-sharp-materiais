namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        { }

        public SavingsAccount(int number, string holder, double balance, double InterestRate) 
            : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
