using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCard : MonoBehaviour
{
    public GameObject correctCard;
    public GameObject answerCard;
    Card card;
    SetPage setPage;

    // Start is called before the first frame update
    void Start()
    {
        setPage = gameObject.GetComponent<SetPage>();
        card = correctCard.GetComponent<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropCard()
    {
        Debug.Log("MouseUp");

        if (correctCard == card.pickCard)
        {
            Debug.Log("�½��ϴ�!");
            gameObject.GetComponent<Image>().sprite = correctCard.GetComponent<Image>().sprite;
            answerCard.SetActive(true);
            setPage.SetnextPage();
        }
        else
            Debug.Log("�ٸ� ī�带 ����� ������");
    }

    
}
