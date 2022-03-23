using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCard : MonoBehaviour
{
    public GameObject correctCard;
    public GameObject answerCard;
    public GameObject next;
    AutoFlip autoFlip;
    Card card;

    // Start is called before the first frame update
    void Start()
    {
        card = correctCard.GetComponent<Card>();
        next.SetActive(false);
        autoFlip = GameObject.Find("Book").GetComponent<AutoFlip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropCard()
    {
        Debug.Log("MouseUp");

        if (correctCard==card.pickCard)
        {
            Debug.Log("맞습니다!");
            gameObject.GetComponent<Image>().sprite = correctCard.GetComponent<Image>().sprite;
            answerCard.SetActive(true);
            next.SetActive(true);
            autoFlip.FlipRightPage();

        }
    }

    
}
