//Private set properties

//Private set properties allow a property to be read from anywhere but only modified within the class itself.
//This provides controlled access to data while maintaining encapsulation.


//Example usage
var counter = new Counter();
counter.Increment();
int value = counter.Count;
// counter.Count = 10;         //Error: cannot set from outside
public class Counter
{
    public int Count { get; private set; } = 0;     //Auto-property initializer. It sets the starting value when the object is created.

    public void Increment()
    {
        Count++;    //Value can be changed inside the class.
    }
}


//Syntax
public class BankAccount
{
    public string Name { get; private set; }        //Anyone can read, only class can write.
    public decimal Balance { get; private set; }
}



//Test: create a BankAccount class with private set properties:
//          AccountHolder property: can be read publicly but only set privately
//          Balance property: can be read publicly but only set privately
//          Constructor: accepts account holder name and initial deposit amount
//          Deposit method: adds to balance and returns new balance
//          Withdraw method: subtracts from balance if sufficient funds, returns new balance.Returns - 1 if insufficient funds.
public class BankAccountSolution
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccountSolution(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public decimal Deposit(decimal amount)
    {
        Balance += amount;
        return Balance;
    }
    public decimal Withdraw(decimal amount)
    {
        if(Balance - amount >= 0)
        {
            Balance -= amount;
            return Balance;
        }
        else
        {
            return -1;
        }
    }
}