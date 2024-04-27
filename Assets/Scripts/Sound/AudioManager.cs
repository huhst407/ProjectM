using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            AfterSound();
        }
    }

    void PlaySound()
    {
        audioSource.Play();
    }

    void AfterSound()
    {
        Debug.Log("Do Something After Audio Finished Playing.");
    }
}
