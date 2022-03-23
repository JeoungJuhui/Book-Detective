using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCardSlot : MonoBehaviour
{
    public List<GameObject> CaracterCardList;
    public GameObject CaracterCardSlot;
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

        cardManager.CardAlignment(cardnum); //�̰� ��ư �������� ������ �� setactive ���� ������ ����

        cardManager.SetSlotCard();
    }


}
