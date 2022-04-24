using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepAudio : MonoBehaviour
{

    public Transform last_loc;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        last_loc = Camera.main.transform;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Camera.main.transform.position, last_loc.position);

        // If camera hasn't moved, mute footsteps
        if (dist < 1f)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 1;
        }
        

        last_loc = Camera.main.transform;
    }
}


