using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCardSlot : MonoBehaviour
{
    public List<GameObject> CaracterCardList;
    public GameObject CaracterCardSlot;
    int setSlotNum = 0;
    CardManager cardManager;

    // Start is called before the first frame update
    void Start()
    {
        cardManager = gameObject.GetComponent<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        int cardnum = CaracterCardList.Count;

        switch (cardnum)
        {
            case 0:
                break;
            case 1:
                cardManager.CardAlignment1(); //�̰� ��ư �������� ������ �� setactive ���� ������ ����
                break;
            case 2:
                cardManager.CardAlignment2();
                break;

        }

        cardManager.SetSlotCard();
    }
}
