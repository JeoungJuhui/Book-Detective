using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    Book book;
    SetPage setPage;
    public int currentP;

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

    void PageActive()
    {
        if (transform.GetChild(currentP / 2).gameObject)
            transform.GetChild(currentP / 2).gameObject.SetActive(true);
        else
            return;

        if (currentP! != book.currentPage)
        {
            transform.GetChild(currentP / 2).gameObject.SetActive(false);
            currentP = book.currentPage;
        }
        else
            return;
    }

    
}
