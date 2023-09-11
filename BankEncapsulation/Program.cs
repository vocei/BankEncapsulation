namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
          BankAccount ba = new BankAccount();

            Console.WriteLine("How much $ would you like to deposit today?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
           double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current account balance is: {userBalance, 0:c}");
        }
    }
}
