using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSystem : MonoBehaviour
{
    GameObject slot;
    GameObject slotList;
    GameObject cardList;
    Transform slot_pos;

    float slot_x;

    // Start is called before the first frame update
    void Start()
    {
        slot = gameObject;
        slot_pos = slot.transform;
        slot_x = slot_pos.position.x;
        slot.transform.position = new Vector3(1550f, slot_pos.position.y, slot_pos.position.z);
        slotList = GameObject.Find("SlotList");
        cardList = GameObject.Find("CardList");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start_moveSlot()
    {
        StartCoroutine(slot_Move());
    }

    IEnumerator slot_Move()
    {
        if (slot_pos.position.x < 1550f)
        {
            while (slot_pos.position.x < 1550f)
            {
                slot_pos.position = Vector3.MoveTowards(slot_pos.position, new Vector3(1550f, slot_pos.position.y, slot_pos.position.z), 15f);
                yield return null;

            }
        }

        else
        {
            while (slot_x < slot_pos.position.x)
            {
                slot_pos.position = Vector3.MoveTowards(slot_pos.position, new Vector3(slot_x, slot_pos.position.y, slot_pos.position.z), 15f);
                yield return null;

            }
        }

    }
    public void slot_Out()
    {
        cardList.transform.GetChild(0).gameObject.SetActive(false);
        slotList.transform.position -= new Vector3(150.0f, 0, 0);
    }
    public void slot_In()
    {
        cardList.transform.GetChild(0).gameObject.SetActive(true);
        slotList.transform.position += new Vector3(150.0f, 0, 0);
    }
}
