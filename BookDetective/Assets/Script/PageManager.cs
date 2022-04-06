using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    Book book;
    SetPage setPage;
    public int currentP;//이거 지우면 문제 생기는지 확인하고 코드 정리하자 스크립트 삭제.

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

    //현재페이지에 +1한 다음에 나누기 2 해서 페이지 이름으로 찾기. setpage도 잊지 않기!
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
