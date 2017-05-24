using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

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
    public Text daysToShow, userName;

    private GameObject[] rewardsArray;
    [SerializeField]
    private List<Sprite> itemRandomList;

	private void Awake()
    {
        today = Days.Monday;
        daysToShow.text = today.ToString();
        userName.text = "Welcome back, Breaking Mad";

        itemRandomList = Resources.LoadAll<Sprite>("RandomElements").ToList();        
        rewardsArray = GameObject.FindGameObjectsWithTag("Items");

        ControllerDays();
	}

    // Control that in each day you can interact to the right question mark
    private void ControllerDays()
    {
        switch (today)
        {
            case Days.Monday:
                Randomizer("Item 0");
                break;
            case Days.Tuesday:
                Randomizer("Item 1");
                break;
            case Days.Wednesday:
                Randomizer("Item 2");
                break;
            case Days.Thursday:
                Randomizer("Item 3");
                break;
            case Days.Friday:
                Randomizer("Item 4");
                break;
            case Days.Saturday:
                Randomizer("Item 5");
                break;
            case Days.Sunday:
                Randomizer("Item 6");
                break;
        }
    }

    private void Randomizer(string questionName)
    {
        GameObject.Find(questionName).GetComponent<Button>().interactable = true;
        GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
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

        else
        {
            today = Days.Monday;
            daysToShow.text = today.ToString();

            for (int i = 0; i < rewardsArray.Length; i++)
            {
                rewardsArray[i].GetComponent<Item>().ResetIcon();
            }

            ControllerDays();
        }
    }


}
