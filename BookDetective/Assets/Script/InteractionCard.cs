using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCard : MonoBehaviour
{

    Card card;
    SetPage setPage;
    CardManager cardManager;
    public List<GameObject> answercards;
    public List<int> nextPagenum;



    // Start is called before the first frame update
    void Start()
    {
        setPage = gameObject.GetComponent<SetPage>();
        cardManager = GameObject.Find("CardSystem").GetComponent<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropCard()
    {

        for (int i=0; i < answercards.Count; i++)
        {
            card = answercards[i].GetComponent<Card>();

            if (answercards[i] == cardManager.selectCard)
            {
                Debug.Log("�½��ϴ�!");
                Debug.Log(answercards[i].name);
                setPage.buttonnextPage = nextPagenum[i];
                setPage.SetnextPage();
                break;
            }
            else
                Debug.Log("�ٸ� ī�带 ����� ������");

            
        }
        cardManager.selectCard = null;

    }


}
