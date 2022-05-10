using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSystem : MonoBehaviour
{
    GameObject slot;
    Transform slot_pos;

    float slot_x;

    // Start is called before the first frame update
    void Start()
    {
        slot = gameObject;
        slot_pos = slot.transform;
        slot_x = slot_pos.position.x;
        slot.transform.position = new Vector3(1550f, slot_pos.position.y, slot_pos.position.z);
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
                slot_pos.position = Vector3.MoveTowards(slot_pos.position, new Vector3(1550f, slot_pos.position.y, slot_pos.position.z), 3f);
                yield return null;

            }
        }

        else
        {
            while (slot_x < slot_pos.position.x)
            {
                slot_pos.position = Vector3.MoveTowards(slot_pos.position, new Vector3(slot_x, slot_pos.position.y, slot_pos.position.z), 3f);
                yield return null;

            }
        }

    }
}
