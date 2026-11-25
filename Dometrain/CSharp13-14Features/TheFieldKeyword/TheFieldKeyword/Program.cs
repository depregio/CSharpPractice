//The field keyword

//The field keyword provides direct access to a property's auto-generated backing field within property accessors,
//eliminating the need to declare explicit backing fields.

//Benefits of field
//      BENEFIT             DESCRIPTION
//      Less boilerplate	No need to declare backing fields manually
//      Naming consistency	No _name vs name confusion
//      Cleaner code	    Property logic stays self-contained
//      Refactoring safety	Compiler manages the backing field


//Traditional approach vs field keyword
private string _name;           //Traditional: explicit backing field required
public string Name
{
    get => _name;
    set
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Name required");
        _name = value;
    }
}

public string Name              //C# 14: using field keyword
{
    get => field;
    set
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Name required");
        field = value;
    }
}


//Validation pattern
public int Age
{
    get => field;
    set
    {
        if (value < 0 || value > 150)
            throw new ArgumentOutOfRangeException();
        field = value;
    }
}



//Test: refactor the EmailValidator class to use the field keyword instead of an explicit backing field.
//      The Email property should:
//          - Use field in both getter and setter
//          - Validate that the email contains '@' before setting
//          - Throw ArgumentException with message "Invalid email format" for invalid emails
//          - Also reject null or empty strings as invalid
public class EmailValidator
{
    public string Email
    {
        get => field;
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Contains("@"))
                field = value;
            else
                throw new ArgumentException("Invalid email format");
        }
    }
}

public class Solution
{
    public static string ValidateAndGetEmail(string email)
    {
        var validator = new EmailValidator();
        validator.Email = email;
        return validator.Email;
    }
}