using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    CardManager cardManager;
    GameObject cardsystem;

    GameObject slotList;
    bool drag;
    int num;

    // Start is called before the first frame update

    private void Awake()
    {
        cardsystem = GameObject.Find("CardSystem").transform.gameObject;
        cardManager = cardsystem.GetComponent<CardManager>();
        num = cardManager.cardList.Count;

    }
    void Start()
    {
        slotList = GameObject.Find("SlotList");
        StartCoroutine(EnmoveCard());
        drag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!drag)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, slotList.transform.GetChild(num - 1).position, 2.5f);

    }

     public void SelectCard()
     {
        cardsystem.SetActive(false);
        StartCoroutine(EnlargeCard());
        
     }

    public void ExitCard()
    {
        cardsystem.SetActive(true);
        StartCoroutine(EnsmallCard());
        drag = false;

    }

    public void CardMouseDrag()
    {
        drag = true;
        gameObject.transform.position = Input.mousePosition;
        cardManager.selectCard= gameObject;
    }

    public void CardMouseUP()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, -40f, +80f);

    }

    IEnumerator EnlargeCard()
    {

        while (gameObject.transform.localScale.x < 1.2)
            gameObject.transform.localScale += new Vector3(0.3f, 0.3f, 0.0001f);

        Debug.Log(gameObject.transform.localScale.x);
        StopCoroutine(EnlargeCard());

        yield return null;
    }

    IEnumerator EnsmallCard()
    {
       
        while (gameObject.transform.localScale.x > 0.9)
            gameObject.transform.localScale -= new Vector3(0.3f, 0.3f, 0.0001f);
     
        StopCoroutine(EnsmallCard());
        
        yield return null;

    }

    IEnumerator EnmoveCard()
    {
        while (gameObject.transform.localScale.x <= 0.9)
            gameObject.transform.localScale += new Vector3(0.3f, 0.3f, 0.0001f);

        StopCoroutine(EnsmallCard());

        yield return null;

    }

}
