using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    Book book;
    public int currentP;
    public GameObject answerCard_end;
    Text answerText;
    GameObject activePage;
    GameObject nextactivePage;

    // Start is called before the first frame update
    void Start()
    {
        book = GameObject.Find("Book").GetComponent<Book>();
        currentP = book.currentPage;

    }

    // Update is called once per frame
    void Update()
    {
        activePage = transform.Find("Page" + ((currentP + 1) / 2)).gameObject;
        nextactivePage = transform.Find("Page" + ((currentP + 3) / 2)).gameObject;
        PageActive();
    }

    //현재페이지에 +1한 다음에 나누기 2 해서 페이지 이름으로 찾기. setpage도 잊지 않기!
    void PageActive()
    {
        if (activePage)
        {
            Debug.Log(activePage.name);
            activePage.SetActive(true);
            if (answerCard_end != null)
                ChangeEndingScript();
        }
        else
            return;

        if (currentP! != book.currentPage)
        {
            activePage.SetActive(false);
            currentP = book.currentPage;
        }
        else
            return;
    }

    void ChangeEndingScript()
    {
        if(nextactivePage.transform.Find("AnswerText"))
            nextactivePage.transform.Find("AnswerText").GetComponent<Text>().text
                = answerCard_end.transform.Find("Title").GetComponent<Text>().text;
        
    }


}
