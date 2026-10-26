//Private access modifier

//The private keyword restricts access to a member so it can only be used within the same class.
//This is fundamental to encapsulation - hiding internal data and exposing controlled access through public methods.

//Example
using System.Data.SqlTypes;

Counter c = new Counter();

//c.count = 100;            //Error: 'count' is private
c.Increment();              //Using a public method
int value = c.GetCount();   //Using a public method     //c.count value is 1

public class Counter
{
    private int count;      //Only accessible inside Counter class  //No constructor, its value is set to 0 upon instantiation.

    public void Increment()
    {
        count++;            //Value is accessible inside the class
    }

    public int GetCount()
    {
        return count;       //Value is accessible inside the class
    }
}


//Encapsulation pattern
public class Temperature
{
    private double celsius;     //Hidden internal state

    public void SetCelsius(double value)
    {
        if (value >= -273.15)   //Validation before storing
            celsius = value;
    }

    public double GetCelsius()
    {
        return celsius;
    }
}



//Test: create a BankAccount class that uses private fields to protect the balance from direct manipulation:
//          A private balance field
//          A constructor that sets the initial balance
//          A public GetBalance() method to read the balance
//          A public Deposit(double amount) method to add money
//          A public Withdraw(double amount) method that:
//              Returns true and deducts the amount if sufficient funds
//              Returns false and leaves balance unchanged if insufficient funds
public class BankAccount
{
    private double balance;     //The exercise says to use double. For real money, decimal is the correct choice.


    public BankAccount(double balance)
    {
        this.balance = balance;
    }


    public double GetBalance()
    {
        return balance;
    }
    
    public void Deposit(double amount)
    {
        balance += amount;
    }
    
    public bool Withdraw(double amount)
    {
        if(balance - amount >= 0)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}