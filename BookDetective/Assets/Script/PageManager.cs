using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    Book book;
    SetPage setPage;
    public int currentP;//�̰� ����� ���� ������� Ȯ���ϰ� �ڵ� �������� ��ũ��Ʈ ����.

    // Start is called before the first frame update
    void Start()
    {
        book = GameObject.Find("Book").GetComponent<Book>();
        currentP = book.currentPage;

    }

    // Update is called once per frame
    void Update()
    {
        PageActive();
    }

    //������������ +1�� ������ ������ 2 �ؼ� ������ �̸����� ã��. setpage�� ���� �ʱ�!
    void PageActive()
    {
        if (transform.Find("Page" + ((currentP + 1) / 2)).gameObject)
        {
            transform.Find("Page" + ((currentP + 1) / 2)).gameObject.SetActive(true);
        }
        else
            return;

        if (currentP! != book.currentPage)
        {
            transform.Find("Page" + ((currentP + 1) / 2)).gameObject.SetActive(false);
            currentP = book.currentPage;
        }
        else
            return;
    }

    
}
