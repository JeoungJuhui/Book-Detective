using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewCard : MonoBehaviour
{
    public GameObject viewSlot;

    Image image;

    private void Start()
    {
        image = gameObject.transform.parent.gameObject.GetComponent<Image>();
    }

    private void Update()
    {
        if(viewSlot.transform.parent.gameObject.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                viewSlot.transform.parent.gameObject.SetActive(false);
            }
            else
                return;
            
        }
    }
    public void selectCard()
    {
        viewSlot.GetComponent<Image>().sprite = image.sprite;
    }

}
