using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGame : MonoBehaviour
{
    public GameObject gameStart;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (gameStart.transform.GetChild(i+1).gameObject)
        {
            if (gameStart.transform.GetChild(i).gameObject.activeSelf)
                if (!gameStart.transform.GetChild(i + 1).gameObject.activeSelf)
                    Restart();
                else
                    return;
            else
                return;

            i += 1;
        } 
        if(!gameStart.transform.GetChild(4).gameObject.activeSelf)
        {
            next.SetActive(true);
        }
    }

    void Restart()
    {
        int i = 0;

        while (gameStart.transform.GetChild(i).gameObject)
        {
            gameStart.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
