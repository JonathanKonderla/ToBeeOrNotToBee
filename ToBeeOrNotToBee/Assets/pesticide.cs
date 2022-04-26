using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesticide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "bug")
        {
            Destroy(gameObject);
        }else if(other.gameObject.name == "Grass_01")
        {
            Destroy(other.gameObject);
        }
    }
}
