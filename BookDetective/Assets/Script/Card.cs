using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    CardManager cardManager;
    GameObject cardsystem;

    bool select;

    // Start is called before the first frame update

    private void Awake()
    {
        cardsystem = GameObject.Find("CardSystem").transform.gameObject;
        cardManager = cardsystem.GetComponent<CardManager>();


    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

     public void SelectCard()
    {
        cardsystem.SetActive(false);
        select = true;


       StartCoroutine(EnlargeCard(select));
        
    }

    public void ExitCard()
    {
        cardsystem.SetActive(true);
        select = false;
        StartCoroutine(EnsmallCard(select)); 

    }

    public void CardMouseDrag()
    {
        gameObject.transform.position = Input.mousePosition;
        cardManager.selectCard= gameObject;
    }

    public void CardMouseUP()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -40f, +80f);

    }

    IEnumerator EnlargeCard(bool select)
    {
        if (select)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, +80f, -100f);
            while (gameObject.transform.localScale.x <= 1.5)
                gameObject.transform.localScale += new Vector3(0.5f, 0.5f, 0.0001f);
        }
        StopCoroutine(EnlargeCard(select));

        yield return null;
    }

    IEnumerator EnsmallCard(bool select)
    {
        if (!select)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -40f, +100f);
            while (gameObject.transform.localScale.x >= 1)
                gameObject.transform.localScale -= new Vector3(0.5f, 0.5f, 0.0001f);
        }
        StopCoroutine(EnsmallCard(select));
        
        yield return null;


    }

}
