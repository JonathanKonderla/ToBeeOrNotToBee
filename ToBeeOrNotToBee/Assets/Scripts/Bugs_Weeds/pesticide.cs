using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesticide : MonoBehaviour
{
    private int usesLeft = 6;
    private AudioSource audioSource;
    public AudioClip spraySound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bug"))
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(spraySound);
            usesLeft--;
        }
        else if(other.gameObject.CompareTag("Weed"))
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(spraySound);
            usesLeft--;
        }

        if (usesLeft == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
