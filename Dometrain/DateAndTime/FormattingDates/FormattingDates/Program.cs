//Formatting dates with ToString

//The DateTime.ToString() method accepts format strings that control how dates appear.
//This is essential for displaying dates to users or generating standardized output.

//Format specifier reference
//      SPECIFIER	DESCRIPTION	        EXAMPLE
//      yyyy	    4-digit year	    2024
//      yy	        2-digit year	    24
//      MM	        2-digit month	    03
//      M	        1 or 2-digit month	3
//      MMMM	    Full month name	    March
//      MMM	        Abbreviated month	Mar
//      dd	        2-digit day	        15
//      d	        1 or 2-digit day	15


//Custom format specifiers
DateTime date = new DateTime(2024, 3, 15);

date.ToString("yyyy-MM-dd");    //"2024-03-15" (ISO format)
date.ToString("dd/MM/yyyy");    //"15/03/2024" (European style)
date.ToString("MM/dd/yyyy");    //"03/15/2024" (US style)
date.ToString("MMMM dd, yyyy"); //"March 15, 2024" (Long month name)


//Standard Format Strings (single-character shortcuts)
date.ToString("d"); //Short date:       "3/15/2024"
date.ToString("D"); //Long date:        "Friday, March 15, 2024"
date.ToString("f"); //Full date/time:   "Friday, March 15, 2024 12:00 AM"



//Test: implement three methods that format a DateTime in different ways:
//          FormatAsIso:        Return the date in ISO format yyyy-MM-dd
//          FormatAsLongDate:   Return the date as MMMM dd, yyyy
//          FormatAsCustom:     Return the date as dd / MM / yyyy
public class Solution
{
    //Format as ISO date: yyyy-MM-dd (e.g., "2024-03-15")
    public static string FormatAsIso(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    //Format as long date: MMMM dd, yyyy (e.g., "March 15, 2024")
    public static string FormatAsLongDate(DateTime date)
    {
        return date.ToString("MMMM dd, yyyy");
    }

    //Format as: dd/MM/yyyy (e.g., "15/03/2024")
    public static string FormatAsCustom(DateTime date)
    {
        return date.ToString("dd/MM/yyyy");
    }
}