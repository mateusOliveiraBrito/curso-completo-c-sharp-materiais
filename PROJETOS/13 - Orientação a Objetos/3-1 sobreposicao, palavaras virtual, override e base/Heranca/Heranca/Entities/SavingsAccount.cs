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

        //a palavra base serve para chamar a implementação da super classe, para casos em que deseja-se reutilizar 
        //o código e adicionar mais alguma função nele.
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2;
        }
    }
}
