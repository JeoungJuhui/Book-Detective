using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlotCtrl : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public int cardNum;
    // Start is called before the first frame update
    void Start()
    {
        slot1.SetActive(false);
        slot2.SetActive(false);
        slot3.SetActive(false);
        slot4.SetActive(false);
    }

    // Update is called once per frame
    public void CheckSlot()
    {
        switch (cardNum)
        {
            case 0:
                break;
            case 1:
                Slot1();
                break;
            case 2:
                Slot2();
                break;
        }
    }

    void Slot1()
    {
        slot1.SetActive(true);

    }
    void Slot2()
    {
        Vector3 changePos = slot1.transform.position;
        changePos.x -= 50;
        Debug.Log(changePos);
        slot1.transform.position = Vector3.MoveTowards(slot1.transform.position, changePos, 50.0f);
        
        slot2.SetActive(true);
        changePos.x += 100;
        slot2.transform.position = Vector3.MoveTowards(slot2.transform.position, changePos, 50.0f);

    }
}
