using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    /// <summary>
    /// Facendo il GetComponentInChildren su questo oggetto non mi trova il componente Image figlio... Bug???
    /// </summary>
    public Image iconImage;
    public Image pokeIcon;
    public Image[] imageArray;
   
    private void Awake()
    {
        iconImage = this.GetComponent<Image>();
        imageArray = GetComponentsInChildren<Image>();
        imageArray[1].enabled = true;
        pokeIcon = imageArray[1];

        //Debug.Log(iconImage.name);

        /*for (int i = 0; i < imageArray.Length - 1; i++)
        {
            Debug.Log(imageArray[1].name);
        }*/

        pokeIcon.transform.localScale = Vector3.zero;
    }

    public void Tap()
    {
        StartCoroutine(ReduceIconCO(iconImage));
        StartCoroutine(SpawnItemCO(pokeIcon));
        StartCoroutine(SpawnItemCO(iconImage));

        iconImage.enabled = false;
        pokeIcon.enabled = true;
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
