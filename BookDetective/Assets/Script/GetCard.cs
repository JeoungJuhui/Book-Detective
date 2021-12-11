using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCard : MonoBehaviour
{

    public GameObject card;
    public GameObject slot;
    public GameObject clueSlot;

    Image image;
    GameObject currentSlot;
    int slotnum;

    // Start is called before the first frame update
    void Start()
    {
        card.transform.localScale = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (card.activeSelf)
        {
            card.transform.position = Vector3.MoveTowards(card.transform.position, slot.transform.position, 2.0f);
            float x = card.transform.localScale.x;
            if (x <= 1)
                card.transform.localScale += new Vector3(0.005f, 0.005f, 0.0001f);
            else
                return;

        }
        else
            return;

    }
    
    public void GetClue()
    {
        slot.GetComponent<CardSlotCtrl>().cardNum+=1;
        slotnum = slot.GetComponent<CardSlotCtrl>().cardNum;
        card.transform.position = gameObject.transform.position;
        card.SetActive(true);

        SetCard();
        slot.GetComponent<CardSlotCtrl>().CheckSlot();
        slot = slot.transform.GetChild(slotnum - 1).gameObject;
        
    }

    public void SetCard()
    {
        int i = 0;

        while (clueSlot.transform.GetChild(i).gameObject.activeSelf)
        {
            i += 1;
        }
        currentSlot = clueSlot.transform.GetChild(i).gameObject;


        image = currentSlot.GetComponent<Image>();
        image.sprite = card.GetComponent<Image>().sprite;
        currentSlot.SetActive(true);

    }
    

}
