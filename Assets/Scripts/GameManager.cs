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
    int dayInt = 0;

    private Days today;
    public Text daysToShow, userName;

    private GameObject[] rewardsArray;
    [SerializeField]
    private List<Sprite> itemRandomList;

    public string lunedì = "none", martedì = "none", mercoledì = "none", giovedì = "none", venerdì = "none", sabato = "none", domenica = "none";
    public int checkLunedì = 1, checkMartedì = 1, checkMercoledì = 1, checkGiovedì = 1 ,checkVenerdì = 1, checkSabato = 1, checkDomenica = 1;

    private void Start()
    {
        dayInt = PlayerPrefs.GetInt("dayInt", dayInt);
        PlayerPrefs.Save();

        lunedì = PlayerPrefs.GetString("lunedì", lunedì);
        martedì = PlayerPrefs.GetString("martedì", martedì);
        mercoledì = PlayerPrefs.GetString("mercoledì", mercoledì);
        giovedì = PlayerPrefs.GetString("giovedì", giovedì);
        venerdì = PlayerPrefs.GetString("venerdì", venerdì);
        sabato = PlayerPrefs.GetString("sabato", sabato);
        domenica = PlayerPrefs.GetString("domenica", domenica);
        PlayerPrefs.Save();

        checkLunedì = PlayerPrefs.GetInt("checkLunedì", checkLunedì);
        checkMartedì = PlayerPrefs.GetInt("checkMartedì", checkMartedì);
        checkMercoledì = PlayerPrefs.GetInt("checkMercoledì", checkMercoledì);
        checkGiovedì = PlayerPrefs.GetInt("checkGiovedì", checkGiovedì);
        checkVenerdì = PlayerPrefs.GetInt("checkVenerdì", checkVenerdì);
        checkSabato = PlayerPrefs.GetInt("checkSabato", checkSabato);
        checkDomenica = PlayerPrefs.GetInt("checkDomenica", checkDomenica);
        PlayerPrefs.Save();


        today = Days.Monday;
        today += PlayerPrefs.GetInt("dayInt", dayInt);
        daysToShow.text = today.ToString();
        userName.text = "Welcome back, Breaking Mad";

        itemRandomList = Resources.LoadAll<Sprite>("RandomElements").ToList();        
        rewardsArray = GameObject.FindGameObjectsWithTag("Items");
        
        ControllerDays();
        CellControl();

        

    }

    public void CheckMyStatus(string name)
    {

        switch (name)
        {
            case "Item 0":
            checkLunedì = 0;
                PlayerPrefs.SetInt("checkLunedì", checkLunedì);
                PlayerPrefs.Save();
                break;
            case "Item 1":
                checkMartedì = 0;
                PlayerPrefs.SetInt("checkMartedì", checkMartedì);
                PlayerPrefs.Save();
                break;
            case "Item 2":
                checkMercoledì = 0;
                PlayerPrefs.SetInt("checkMercoledì", checkMercoledì);
                PlayerPrefs.Save();
                break;
            case "Item 3":
                checkGiovedì = 0;
                PlayerPrefs.SetInt("checkGiovedì", checkGiovedì);
                PlayerPrefs.Save();
                break;
            case "Item 4":
                checkVenerdì = 0;
                PlayerPrefs.SetInt("checkVenerdì", checkVenerdì);
                PlayerPrefs.Save();
                break;
            case "Item 5":
                checkSabato = 0;
                PlayerPrefs.SetInt("checkSabato", checkSabato);
                PlayerPrefs.Save();
                break;
            case "Item 6":
                checkDomenica = 0;
                PlayerPrefs.SetInt("checkDomenica", checkDomenica);
                PlayerPrefs.Save();
                break;
        }
    }

    // Control that in each day you can interact to the right question mark
    public void ControllerDays()
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

        CellControl();

        switch (questionName)
        {
            case "Item 0":
                if (lunedì == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    lunedì = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("lunedì", lunedì);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 1":
                if (martedì == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    martedì = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("martedì", martedì);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 2":
                if (mercoledì == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    mercoledì = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("mercoledì", mercoledì);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 3":
                if (giovedì == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    giovedì = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("giovedì", giovedì);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 4":
                if (venerdì == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    venerdì = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("venerdì", venerdì);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 5":
                if (sabato == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    sabato = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("sabato", sabato);
                    PlayerPrefs.Save();
                }
                break;
            case "Item 6":
                if (domenica == "none")
                {
                    GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite = itemRandomList[Random.Range(0, itemRandomList.Count)];
                    domenica = GameObject.Find(questionName).transform.GetChild(0).GetComponent<Image>().sprite.name;
                    PlayerPrefs.SetString("domenica", domenica);
                    PlayerPrefs.Save();
                }
                break;

        }

        
    }

    public void CellControl()
    {
        if (dayInt >= 0 && lunedì == "none")
        {
            GameObject.Find("Item 0").GetComponent<Button>().interactable = true;

        }
        else if (dayInt >= 0 && lunedì != "none" && checkLunedì == 1)
        {
            GameObject.Find("Item 0").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 0").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(lunedì);
        }
        else if (dayInt >= 0 && lunedì != "none" && checkLunedì == 0)
        {
            GameObject.Find("Item 0").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(lunedì);
            GameObject.Find("Item 0").transform.GetComponent<Item>().Tap();
        }

        if (dayInt >= 1 && martedì == "none")
        {
            GameObject.Find("Item 1").GetComponent<Button>().interactable = true;

        }
        else if (dayInt >= 1 && martedì != "none" && checkMartedì == 1)
        {
            GameObject.Find("Item 1").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 1").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(martedì);
        }
        else if (dayInt >= 1 && martedì != "none" && checkMartedì == 0)
        {
            GameObject.Find("Item 1").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(martedì);
            GameObject.Find("Item 1").transform.GetComponent<Item>().Tap();
        }
        if (dayInt >= 2 && mercoledì == "none")
        {
            GameObject.Find("Item 2").GetComponent<Button>().interactable = true;
        }
        else if (dayInt >= 2 && mercoledì != "none" && checkMercoledì == 1)
        {
            GameObject.Find("Item 2").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 2").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(mercoledì);
        }
        else if (dayInt >= 2 && mercoledì != "none" && checkMercoledì == 0)
        {
            GameObject.Find("Item 2").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(mercoledì);
            GameObject.Find("Item 2").transform.GetComponent<Item>().Tap();
        }
        if (dayInt >= 3 && giovedì == "none")
        {
            GameObject.Find("Item 3").GetComponent<Button>().interactable = true;
        }
        else if (dayInt >= 3 && giovedì != "none" && checkGiovedì == 1)
        {
            GameObject.Find("Item 3").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 3").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(giovedì);
        }
        else if (dayInt >= 3 && giovedì != "none" && checkGiovedì == 0)
        {
            GameObject.Find("Item 3").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(giovedì);
            GameObject.Find("Item 3").transform.GetComponent<Item>().Tap();

        }
        if (dayInt >= 4 && venerdì == "none")
        {
            GameObject.Find("Item 4").GetComponent<Button>().interactable = true;
        }
        else if (dayInt >= 4 && venerdì != "none" && checkVenerdì == 1)
        {
            GameObject.Find("Item 4").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 4").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(venerdì);
        }
        else if (dayInt >= 4 && venerdì != "none" && checkVenerdì == 0)
        {
            GameObject.Find("Item 4").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(venerdì);
            GameObject.Find("Item 4").transform.GetComponent<Item>().Tap();
        }
        if (dayInt >= 5 && sabato == "none")
        {
            GameObject.Find("Item 5").GetComponent<Button>().interactable = true;
        }
        else if (dayInt >= 5 && sabato != "none" && checkSabato == 1)
        {
            GameObject.Find("Item 5").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 5").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(sabato);
        }
        else if (dayInt >= 5 && sabato != "none" && checkSabato == 0)
        {
            GameObject.Find("Item 5").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(sabato);
            GameObject.Find("Item 5").transform.GetComponent<Item>().Tap();
        }
        if (dayInt >= 6 && domenica == "none")
        {
            GameObject.Find("Item 6").GetComponent<Button>().interactable = true;
        }
        else if (dayInt >= 6 && domenica != "none" && checkDomenica == 1)
        {
            GameObject.Find("Item 6").GetComponent<Button>().interactable = true;
            GameObject.Find("Item 6").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(domenica);
        }
        else if (dayInt >= 6 && domenica != "none" && checkDomenica == 0)
        {
            GameObject.Find("Item 6").transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>(domenica);
            GameObject.Find("Item 6").transform.GetComponent<Item>().Tap();
        }

    }

    public void ResetTheName()
    {
        lunedì = "none";
        PlayerPrefs.SetString("lunedì", lunedì);
        martedì = "none";
        PlayerPrefs.SetString("martedì", martedì);
        mercoledì = "none";
        PlayerPrefs.SetString("mercoledì", mercoledì);
        giovedì = "none";
        PlayerPrefs.SetString("giovedì", giovedì);
        venerdì = "none";
        PlayerPrefs.SetString("venerdì", venerdì);
        sabato = "none";
        PlayerPrefs.SetString("sabato", sabato);
        domenica = "none";
        PlayerPrefs.SetString("domenica", domenica);

        checkLunedì = 1;
        PlayerPrefs.SetInt("checkLunedì", checkLunedì);
        checkMartedì = 1;
        PlayerPrefs.SetInt("checkMartedì", checkMartedì);
        checkMercoledì = 1;
        PlayerPrefs.SetInt("checkMercoledì", checkMercoledì);
        checkGiovedì = 1;
        PlayerPrefs.SetInt("checkGiovedì", checkGiovedì);
        checkVenerdì = 1;
        PlayerPrefs.SetInt("checkVenerdì", checkVenerdì);
        checkSabato = 1;
        PlayerPrefs.SetInt("checkSabato", checkSabato);
        checkDomenica = 1;
        PlayerPrefs.SetInt("checkDomenica", checkDomenica);
        PlayerPrefs.Save();
        


    }

    // By the button NextDay go to the next day and reset the count on Sunday
    public void SwitchDays()
    {
        CellControl();

        if (today != Days.Sunday)
        {
            today += 1;
            daysToShow.text = today.ToString();
            dayInt += 1;
            PlayerPrefs.SetInt("dayInt", dayInt);
            PlayerPrefs.Save();
            ControllerDays();
            

        }

        else if (today == Days.Sunday || PlayerPrefs.GetInt("dayInt", dayInt) > 6)
        {
            ResetTheName();
            today = Days.Monday;
            dayInt = 0;
            
            PlayerPrefs.SetInt("dayInt", dayInt);
            PlayerPrefs.Save();

            daysToShow.text = today.ToString();

            for (int i = 0; i < rewardsArray.Length; i++)
            {
                rewardsArray[i].GetComponent<Item>().ResetIcon();
            }

            ControllerDays();
        }

        Debug.Log(PlayerPrefs.GetInt("dayInt", dayInt));
    }


}
