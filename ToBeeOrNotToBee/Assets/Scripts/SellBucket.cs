using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBucket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            //Destroy(other.gameObject.transform.parent.gameObject);
            float sellPrice = other.gameObject.transform.parent.gameObject.GetComponent<Plant>().SellPlant();
        }
    }
}
