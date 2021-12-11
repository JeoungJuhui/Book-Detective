using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public AudioClip turnPage;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
    public void TurnPage()
    {
        audioSource.Play();
    }
}
