//Raw string literals

//Raw string literals (C# 11+) let you write strings without escaping special characters.
//They start and end with at least three double quotes (""").

//Raw strings preserve formatting. The closing """ position determines indentation.


//Basic syntax
string json1 = "{\"name\": \"John\"}";  //Traditional string: requires escaping.

string json2 = """                      
               {"name": "John"}         
               """;                     //Raw string literal: no escaping needed.


//Multiline strings
string html = """
              <div>
                  <p>Hello World</p>
              </div>
              """;                      //Result has no leading spaces. They're trimmed based on closing quotes.


//String interpolation with raw strings
string name = "Alice";
int score = 95;
                                        //Use $$ prefix with double braces {{}} for interpolation.
string result = $$"""
                Name: {{name}}
                Score: {{score}}
                """;                    //The number of $ signs determines how many braces are needed for interpolation.


//Why double braces?



string json = $$"""
              { "person": "{{name}}" }
              """;                      //This outputs literal { } in the JSON, but {{name}} gets replaced.
                                        //JSON uses { } for objects. With $$, single braces { } are literal, and {{}} triggers interpolation.



//Test: create a method that returns a JSON string representing a person using raw string literals with interpolation.
public class Solution
{
    public static string CreatePersonJson(string name, int age, string city)
    {
        return $$"""
            {
                "name": "{{name}}",
                "age": {{age}},
                "city": "{{city}}"
            }
            """;
    }
}