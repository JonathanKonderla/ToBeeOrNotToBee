using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesticide : MonoBehaviour
{
    private int usesLeft = 6;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bug"))
        {
            Destroy(other.gameObject);
            usesLeft--;
        }
        else if(other.gameObject.CompareTag("Weed"))
        {
            Destroy(other.gameObject);
            usesLeft--;
        }

        if (usesLeft == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
