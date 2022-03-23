using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    CardManager cardManager;

    public GameObject cardsystem;
    public GameObject pickCard;
    bool select;

    // Start is called before the first frame update
    void Start()
    {
        cardManager = cardsystem.GetComponent<CardManager>();
        Debug.Log("Play");
    }

    // Update is called once per frame
    void Update()
    {
    }

     public void SelectCard()
    {
        cardsystem.SetActive(false);
        Debug.Log("MouseOver");
        select = true;
        EnlargeCard(select);
        
    }

    public void ExitCard()
    {
        cardsystem.SetActive(true);
        Debug.Log("MouseExit");
        select = false;
        EnsmallCard(select);
    }

    public void CardMouseDrag()
    {
        gameObject.transform.position = Input.mousePosition;
        pickCard = gameObject;
    }

    public void CardMouseUP()
    {
        pickCard = null;
    }

    void EnlargeCard(bool select)
    {
        float x = gameObject.transform.localScale.x;
        if (select)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, +80f, -100f);
            if (x <= 1.5)
                gameObject.transform.localScale += new Vector3(0.5f, 0.5f, 0.0001f);
        }
        else
            return;
    }

    void EnsmallCard(bool select)
    {
        float x = gameObject.transform.localScale.x;
        if (!select)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -40f, +100f);
            if (x >= 1)
                gameObject.transform.localScale -= new Vector3(0.5f, 0.5f, 0.0001f);
        }
        else
            return;
    }

}
