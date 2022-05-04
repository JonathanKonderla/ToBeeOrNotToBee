using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesticide : MonoBehaviour
{
    private int usesLeft = 6;
    private AudioSource audioSource;
    public AudioClip spraySound;
    public bool isOrganic = false;
    public BeeLevel beeLevel;

    private void Awake()
    {
        beeLevel = GameObject.FindGameObjectWithTag("BeeLevel").GetComponent<BeeLevel>();
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bug"))
        {
            other.gameObject.transform.parent.GetComponent<Plant>().DebugPlant();
            audioSource.PlayOneShot(spraySound);
            usesLeft--;
            if (isOrganic == false)
            {
                beeLevel.Decrease_Bees(5);
            }
        }
        else if(other.gameObject.CompareTag("Weed"))
        {
            other.gameObject.transform.parent.GetComponent<DirtPlot>().DeweedPlot();
            Destroy(other.gameObject);
            audioSource.PlayOneShot(spraySound);
            usesLeft--;
            if (isOrganic == false)
            {
                beeLevel.Decrease_Bees(5);
            }
        }

        if (usesLeft == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
