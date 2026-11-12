//Single and SingleOrDefault

//Single() and SingleOrDefault() retrieve exactly one element from a collection.
//Unlike First(), these methods expect only one match and throw an exception if multiple elements satisfy the condition.


//Single() method
using System.Linq;

var numbers = new List<int> { 1, 2, 3, 4, 5 };

var three = numbers.Single(n => n == 3);        //Returns the only element matching the condition       //Returns 3

var ten = numbers.Single(n => n == 10);         //Throws InvalidOperationException if no match          //Exception

var evens = numbers.Single(n => n % 2 == 0);    //Throws InvalidOperationException if multiple matches  //Exception (2 and 4 both match)


//SingleOrDefault() method
var numbers2 = new List<int> { 1, 2, 3, 4, 5 };     //Returns default value (null for reference types, 0 for int) if no match

var ten2 = numbers2.SingleOrDefault(n => n == 10);          //Returns 0

var names = new List<string> { "Alice", "Bob" };
var missing = names.SingleOrDefault(n => n == "Charlie");   //Returns null

var evens2 = numbers2.SingleOrDefault(n => n % 2 == 0);     //Still throws if multiple matches          //Exception



//Test: implement a method to find a user by their email address.
//      Since emails should be unique in a user system, use SingleOrDefault() to enforce this constraint.
//      Return the username if found, or "Not Found" if no user has that email.
public class Solution
{
    public static string FindUserByEmail(List<User> users, string email)
    {
        var correctUser = users.SingleOrDefault(user => user.Email == email);

        return correctUser?.Username ?? "Not Found";    //= return correctUser == null ? "Not Found" : correctUser.Username;

        //?. is the null conditional operator.
        //Access only if not null, otherwise the result is null.
        //Used to avoid a NullReferenceException.

        //It is often used with ?? since
        //?. produces null when something is missing,
        //and ?? turns that null into a usable value.                                                
    }
}

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }

    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }
}