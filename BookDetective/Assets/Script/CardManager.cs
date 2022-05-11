using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardManager : MonoBehaviour
{
    [SerializeField] Transform cardLeft;
    [SerializeField] Transform cardRight;

    public List<GameObject> cardList;
    public List<GameObject> caracterCardList;
    public List<GameObject> missionCardList;

    public GameObject selectCard;

    public GameObject cardSlot;
    public GameObject caracterCardSlot;
    public GameObject missionCardSlot;
    public GameObject collectButton;
    int setSlotNum = 0;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int cardnum = cardList.Count;

        if (cardnum >= 1)
        {
            cardList[cardnum-1].SetActive(true);
        }

        int charnum = caracterCardList.Count;

        if (charnum >= 1)
        {
            caracterCardList[charnum - 1].SetActive(true);
        }


        int casenum = missionCardList.Count;

        if (casenum >= 1)
        {
            missionCardList[casenum - 1].SetActive(true);
        }



    SetSlotCard();

    }



    public void SetSlotCard()
    {
        int num = cardList.Count;
        int num2 = caracterCardList.Count;
        int num3 = missionCardList.Count;

        if (setSlotNum<cardList.Count)
        {
            cardSlot.transform.GetChild(num - 1).gameObject.SetActive(true);
            cardSlot.transform.GetChild(num - 1).GetComponent<Image>().sprite = cardList[cardList.Count - 1].GetComponent<Image>().sprite;
            cardSlot.transform.GetChild(num - 1).transform.Find("Title").GetComponent<Text>().text = cardList[cardList.Count - 1].transform.Find("Title").GetComponent<Text>().text;
            cardSlot.transform.GetChild(num - 1).transform.Find("Text").GetComponent<Text>().text = cardList[cardList.Count - 1].transform.Find("Text").GetComponent<Text>().text;
            //이미지가 아니라 오브젝트 자체를 가지고 올 수 있도록 변경이 필요!
        }

        if (setSlotNum < caracterCardList.Count)
        {
            caracterCardSlot.transform.GetChild(num2 - 1).gameObject.SetActive(true);
            caracterCardSlot.transform.GetChild(num2 - 1).GetComponent<Image>().sprite = caracterCardList[caracterCardList.Count - 1].GetComponent<Image>().sprite;
        }

        if (setSlotNum < missionCardList.Count)
        {
            missionCardSlot.transform.GetChild(num3 - 1).gameObject.SetActive(true);
            missionCardSlot.transform.GetChild(num3 - 1).GetComponent<Image>().sprite = missionCardList[missionCardList.Count - 1].GetComponent<Image>().sprite;
        }
    }

    public void cardDrop()
    {
        gameObject.GetComponent<CardManager>().selectCard = null;
        Debug.Log("Drop");
    }

   

}
