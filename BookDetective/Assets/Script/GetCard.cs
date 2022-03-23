using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCard : MonoBehaviour
{

    public GameObject card;
    CardManager cardManager;


    // Start is called before the first frame update
    void Start()
    {
        cardManager = GameObject.Find("CardSystem").GetComponent<CardManager>();
        card.transform.position = gameObject.transform.position;
        card.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
    public void GetClue()
    {
        cardManager.cardList.Add(card);
    }

    public void GetCharacter()
    {
        cardManager.caracterCardList.Add(card);
    }

    public void GetMission()
    {
        cardManager.missionCardList.Add(card);
    }
}
