using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScenes");
    }

    public void TutorialStart()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
