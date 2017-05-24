using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int enabledButton = 1;

    public int day = 0;
    public int hour = 0;
    public int minute = 0;
    public int second = 0;

    public int Andrea, Daniele, David, Giovanni, Luca, Michele;

    private void Awake()
    {
        if (System.DateTime.Now.Day != PlayerPrefs.GetInt("day", day) &&

            System.DateTime.Now.Hour * 60 *60 + System.DateTime.Now.Minute * 60 + System.DateTime.Now.Second >= 
            PlayerPrefs.GetInt("hour", hour) * 60 * 60 + PlayerPrefs.GetInt("minute", minute) * 60 + PlayerPrefs.GetInt("second", second))
        {
            enabledButton = 1;

            PlayerPrefs.SetInt("enabledButton", enabledButton);
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("enabledButton", enabledButton) == 0)
        {
            day = PlayerPrefs.GetInt("day", day);
            hour = PlayerPrefs.GetInt("hour", hour);
            minute = PlayerPrefs.GetInt("minute", minute);
            second = PlayerPrefs.GetInt("second", second);
            

            PlayerPrefs.SetInt("day", day);
            PlayerPrefs.SetInt("hour", hour);
            PlayerPrefs.SetInt("minute", minute);
            PlayerPrefs.SetInt("second", second);
            

            PlayerPrefs.Save();
        }

        Andrea = PlayerPrefs.GetInt("Andrea", Andrea);
        Daniele = PlayerPrefs.GetInt("Daniele", Daniele);
        David = PlayerPrefs.GetInt("David", David);
        Giovanni = PlayerPrefs.GetInt("Giovanni", Giovanni);
        Luca = PlayerPrefs.GetInt("Luca", Luca);
        Michele = PlayerPrefs.GetInt("Michele", Michele);

        if (PlayerPrefs.GetInt("Andrea",Andrea) == 1)
            this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Andrea");
        if (PlayerPrefs.GetInt("Daniele", Daniele) == 1)
            this.gameObject.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Daniele");
        if (PlayerPrefs.GetInt("David", David) == 1)
            this.gameObject.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("David");
        if (PlayerPrefs.GetInt("Giovanni", Giovanni) == 1)
            this.gameObject.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Giovanni");
        if (PlayerPrefs.GetInt("Luca", Luca) == 1)
            this.gameObject.transform.GetChild(4).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Luca");
        if (PlayerPrefs.GetInt("Michele", Michele) == 1)
            this.gameObject.transform.GetChild(5).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Michele");


    }

    void Start () {

        Debug.Log(System.DateTime.Now.Day);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);
        
        if (PlayerPrefs.GetInt("enabledButton", enabledButton) == 0)
        {
            enabledButton = 0;
            this.GetComponent<Button>().image.color = Color.red;
            PlayerPrefs.SetInt("enabledButton", enabledButton);
            PlayerPrefs.Save();
        }
        
    }
	
	
    public void ButtonDoStuff()
    {
        if (enabledButton == 1)
        {
            enabledButton = 0;
            PlayerPrefs.SetInt("enabledButton", enabledButton);

            day = System.DateTime.Now.Day;
            hour= System.DateTime.Now.Hour;
            minute = System.DateTime.Now.Minute;
            second = System.DateTime.Now.Second;

            PlayerPrefs.SetInt("day", day);
            PlayerPrefs.SetInt("hour", hour);
            PlayerPrefs.SetInt("minute", minute);
            PlayerPrefs.SetInt("second", second);
            

            PlayerPrefs.Save();

            enabledButton = 0;
            this.GetComponent<Button>().image.color = Color.white;


            
            OpenGift();
        }
        
    }

    public void OpenGift()
    {
        int number = Random.Range(1,7);

        switch (number)
        {
            case 1:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("Andrea");
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Andrea");
                Andrea = 1;
                PlayerPrefs.SetInt("Andrea", Andrea);
                PlayerPrefs.Save();
                break;
            case 2:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("Daniele");
                this.gameObject.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Daniele");
                Daniele = 1;
                PlayerPrefs.SetInt("Daniele", Daniele);
                PlayerPrefs.Save();
                break;
            case 3:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("David");
                this.gameObject.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("David");
                David = 1;
                PlayerPrefs.SetInt("David", David);
                PlayerPrefs.Save();
                break;
            case 4:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("Giovanni");
                this.gameObject.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Giovanni");
                Giovanni = 1;
                PlayerPrefs.SetInt("Giovanni", Giovanni);
                PlayerPrefs.Save();
                break;
            case 5:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("Luca");
                this.gameObject.transform.GetChild(4).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Luca");
                Luca = 1;
                PlayerPrefs.SetInt("Luca", Luca);
                PlayerPrefs.Save();
                break;
            case 6:
                this.GetComponent<Button>().image.sprite = Resources.Load<UnityEngine.Sprite>("Michele");
                this.gameObject.transform.GetChild(5).GetComponent<Image>().sprite = Resources.Load<UnityEngine.Sprite>("Michele");
                Michele = 1;
                PlayerPrefs.SetInt("Michele", Michele);
                PlayerPrefs.Save();
                break;
        }
    }

	
}
