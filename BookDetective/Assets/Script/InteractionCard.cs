using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionCard : MonoBehaviour
{

    Card card;
    SetPage setPage;
    public List<GameObject> answercards;
    public List<int> nextPagenum;



    // Start is called before the first frame update
    void Start()
    {
        setPage = gameObject.GetComponent<SetPage>();
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

            if (answercards[i] == card.pickCard)
            {
                Debug.Log("맞습니다!");
                Debug.Log(answercards[i].name);
                setPage.buttonnextPage = nextPagenum[i];
                setPage.SetnextPage();
                break;
            }
            else
                Debug.Log("다른 카드를 사용해 보세요");

            
        }
        card.pickCard = null;

    }

    
}
