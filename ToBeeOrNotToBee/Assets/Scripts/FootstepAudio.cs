using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepAudio : MonoBehaviour
{
    public Transform player;
    private Vector3 last_loc;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        last_loc = player.position;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.position, last_loc);

        // If camera hasn't moved, mute footsteps
        if (dist == 0.0f)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = Mathf.InverseLerp(0.0f, 0.2f, dist);
        }

        last_loc = player.position;
    }
}


