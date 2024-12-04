using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    AudioSource source;
    Collider soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        source.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        source.mute = !source.mute;

    }
}
