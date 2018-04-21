using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestBuddyUserData
{
    public int Id;
    public int Match_Id;
    public char Status;
    public char Type = 'B';
    public char Gender = 'F';
    public string Name = "Kevin Le Alpaca";
    public string Zip;
    public string Borough;
    public string Email;
    public string Phone;
    public bool Employed;
    public int Age = 23;
    public bool Married;
    public string Interests = "Just looking for a friend :)";
    public string Preferred_Communication;
    public string BestTimes_To_Socialize;
    public bool Travel_Independent;
    public int Days_Since_Matched = 1000000;
    public string About_Me;

    public BestBuddyUserData(char inputType, char inputGender, string inputName, string inputInterests, int inputDays)
    {
        Type = inputType;
        Gender = inputGender;
        Name = inputName;
        Interests = inputInterests;
        Days_Since_Matched = inputDays;
    }


    public string GetUserTypeAsString()
    {
        string returnStr = string.Empty;

        if (Type == 'B')
            returnStr = "Buddy";
        else if (Type == 'V')
            returnStr = "Volunteer";

        return returnStr;
    }

    public string GetDaysSinceMatchedAsString()
    {
        return Days_Since_Matched + " days on waitlist";
    }

    public string GetAgedAsString()
    {
        return Age + " years old";
    }
}
