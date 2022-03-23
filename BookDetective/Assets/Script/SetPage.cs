using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ������ ���� ���
//��ư �����ϸ� �� �������� �� �� �ִ�.

//�����ؾ� �� ��: ���� ������ ��ȣ, next��ư


public class SetPage : MonoBehaviour
{
    public int buttonnextPage;
    public bool nextbutton;
    public GameObject nextB;
    Book book;
    AutoFlip autoFlip;


    // Start is called before the first frame update
    void Start()
    {
        book = GameObject.Find("Book").GetComponent<Book>();
        autoFlip = GameObject.Find("Book").GetComponent<AutoFlip>();
        nextB=GameObject.Find("nextpage");


    }

    // Update is called once per frame
    void Update()
    {
        ActiveNextButton();
    }

    public void SetnextPage()
    {
        if (buttonnextPage != 0)
        {
            book.currentPage = buttonnextPage * 2-3;
        }
        else
            return;

        autoFlip.FlipRightPage();

    }
    void ActiveNextButton()
    {
        if (nextbutton == false)
            nextB.SetActive(false);

        else
            nextB.SetActive(true);

    }
}
