using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System;

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
    private Days today;
    private Item refItem;

	private byte day, hour, minute, sec;
	

    public Text daysToShow, userName;

    public GameObject[] itemArray;

	private void Awake()
    {
        refItem = FindObjectOfType<Item>();

        today = Days.Monday;
        daysToShow.text = today.ToString();
        userName.text = "Welcome back, Breaking Mad";

        itemArray = GameObject.FindGameObjectsWithTag("Items");
        ControllerDays();
	}

    // By the button NextDay go to the next day and reset the count on Sunday
    public void SwitchDays()
    {
        if (today != Days.Sunday)
        {
            today += 1;
            daysToShow.text = today.ToString();
            ControllerDays();
        }

		/*if (System.time.day != day) 
		{
			today += 1;
			daysToShow.text = today.ToString();
            ControllerDays();
		}*/

        else
        {
            today = Days.Monday;
            daysToShow.text = today.ToString();

            for (int i = 0; i < itemArray.Length; i++)
            {
                itemArray[i].GetComponent<Item>().ResetIcon();
            }

            ControllerDays();
        }

		



    }

    // Control that in each day you can interact to the right question mark
    private void ControllerDays()
    {
        switch (today)
        {
            case Days.Monday:
                GameObject.Find("Item 0").GetComponent<Button>().interactable = true;
                break;
            case Days.Tuesday:
                GameObject.Find("Item 1").GetComponent<Button>().interactable = true;
                break;
            case Days.Wednesday:
                GameObject.Find("Item 2").GetComponent<Button>().interactable = true;
                break;
            case Days.Thursday:
                GameObject.Find("Item 3").GetComponent<Button>().interactable = true;
                break;
            case Days.Friday:
                GameObject.Find("Item 4").GetComponent<Button>().interactable = true;
                break;
            case Days.Saturday:
                GameObject.Find("Item 5").GetComponent<Button>().interactable = true;
                break;
            case Days.Sunday:
                GameObject.Find("Item 6").GetComponent<Button>().interactable = true;
                break;
        }
    }
}
