using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Image questionIcon;
    private Image rewardIcon;
   
    private void Awake()
    {
        questionIcon = this.GetComponent<Image>();
        rewardIcon = this.gameObject.transform.GetChild(0).GetComponent<Image>();
        rewardIcon.transform.localScale = Vector3.zero;
    }

    // On the tap ReduceCO question mark and SpawnCO item
    public void Tap()
    {
        StartCoroutine(ReduceIconCO(questionIcon));
        StartCoroutine(SpawnItemCO(rewardIcon));
        StartCoroutine(SpawnItemCO(questionIcon));

        questionIcon.enabled = false;
        rewardIcon.enabled = true;
    }

    // Method that reset the icon
    public void ResetIcon()
    {
        questionIcon.enabled = true;
        rewardIcon.enabled = false;
        rewardIcon.transform.localScale = Vector3.zero;
        GetComponent<Button>().interactable = false;
    }

    private IEnumerator ReduceIconCO(Image _icon)
    {
        while (_icon.transform.localScale != Vector3.zero)
        {
            _icon.transform.localScale -= new Vector3(.1f, .1f, .1f);
            yield return null;
        }
    }

    private IEnumerator SpawnItemCO(Image _icon)
    {
        while (_icon.transform.localScale != Vector3.one)
        {
            _icon.transform.localScale += new Vector3(.1f, .1f, .1f);
            yield return null;
        }
    }
}
