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


        EnlargeCard(select); //内风凭
        
    }

    public void ExitCard()
    {
        cardsystem.SetActive(true);
        select = false;
        EnsmallCard(select); //内风凭

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
