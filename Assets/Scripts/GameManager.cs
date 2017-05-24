using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class GameManager : MonoBehaviour
{
    Days today;

	private void Start ()
    {
        today = Days.Monday;
        Debug.Log(today);
	}
	
	private void Update ()
    {
		
	}

    public void SwitchDays()
    {
        if (today != Days.Sunday)
        {
            today += 1;
            Debug.Log(today);
        }
        else
        {
            today = Days.Monday;
            Debug.Log(today);
        }
    }
}
