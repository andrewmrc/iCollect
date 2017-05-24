using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    /// <summary>
    /// Facendo il GetComponentInChildren su questo oggetto non mi trova il componente Image figlio... Bug???
	/// usa GetChild
    /// </summary>
    private Image questionIcon;
    private Image pokeIcon;
    private Image[] imageArray;
   
    private void Awake()
    {
        questionIcon = this.GetComponent<Image>();
        imageArray = GetComponentsInChildren<Image>();
        imageArray[1].enabled = true;
        pokeIcon = imageArray[1];

        pokeIcon.transform.localScale = Vector3.zero;


		questionIcon.sprite = Resources.Load<Sprite>("Pokemon/Squirtle");
    }

    // On the tap ReduceCO question mark and SpawnCO item
    public void Tap()
    {
        StartCoroutine(ReduceIconCO(questionIcon));
        StartCoroutine(SpawnItemCO(pokeIcon));
        StartCoroutine(SpawnItemCO(questionIcon));

        questionIcon.enabled = false;
        pokeIcon.enabled = true;
    }

    // Method that reset the icon
    public void ResetIcon()
    {
        questionIcon.enabled = true;
        pokeIcon.enabled = false;
        pokeIcon.transform.localScale = Vector3.zero;
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
