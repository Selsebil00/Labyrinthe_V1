using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool canOpen = false;

    [SerializeField]
    AudioClip soundOpen, soundCantOpen;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canOpen)
        {
            GetComponent<Animator>().enabled = true;
            myAudioSource.PlayOneShot(soundOpen);
        } else
        {
            myAudioSource.PlayOneShot(soundCantOpen);
        }
    }
}
