using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCard : MonoBehaviour
{

    Card card;
    SetPage setPage;
    CardManager cardManager;
    PageManager pageManager;
    public List<GameObject> answercards;
    public List<int> nextPagenum;



    // Start is called before the first frame update
    void Start()
    {
        setPage = gameObject.GetComponent<SetPage>();
        cardManager = GameObject.Find("CardSystem").GetComponent<CardManager>();
        pageManager = GameObject.Find("PageCtrlCanvas").GetComponent<PageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropCard()
    {

        for (int i=0; i < answercards.Count; i++)
        {

            if (answercards[i] == GameObject.Find("CardSystem").GetComponent<CardManager>().selectCard)
            {
                Debug.Log("맞습니다!");
                Debug.Log(answercards[i].name);
                setPage.buttonnextPage = nextPagenum[i];
                setPage.SetnextPage();
                pageManager.answerCard_end = answercards[i];
                break;
            }
            else
                Debug.Log("다른 카드를 사용해 보세요");

            
        }
        cardManager.selectCard = null;

    }


}
