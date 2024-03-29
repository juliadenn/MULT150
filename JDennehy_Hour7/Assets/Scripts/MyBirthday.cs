using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Change these variables to your birthday month and day
    public int birthdayMonth = 9; // Example: September
    public int birthdayDay = 23;   // Example: 23rd

    void Start()
    {
        for (int month = 1; month <= 12; month++)
        {
            if (month == birthdayMonth)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(month);
            }
        }

        int daysInBirthdayMonth = GetDaysInMonth(birthdayMonth);
        for (int day = 1; day <= daysInBirthdayMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    int GetDaysInMonth(int month)
    {
        switch (month)
        {
            case 2: // February
                return System.DateTime.DaysInMonth(System.DateTime.Now.Year, month);
            case 4: // April
            case 6: // June
            case 9: // September
            case 11: // November
                return 30;
            default:
                return 31;
        }
    }

// Update is called once per frame
void Update()
    {

    }
}
