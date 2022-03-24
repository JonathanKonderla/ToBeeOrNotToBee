using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPlot : MonoBehaviour
{
    private bool isEmpty = true;
    public bool isPlowed = false;

    public Material unplowedMat;
    public Material plowedMat;


    private void OnTriggerEnter(Collider other)
    {
        if(isEmpty && isPlowed && other.gameObject.CompareTag("Seed"))
        {
            GameObject plant = other.gameObject.transform.parent.gameObject;
            plant.GetComponent<Plant>().PlantSeed();
            plant.transform.position = this.transform.position;
            plant.transform.rotation = Quaternion.identity;
            isEmpty = false;
        }
        else if (other.gameObject.CompareTag("Plow"))
        {
            isPlowed = true;
            GetComponent<MeshRenderer>().material = plowedMat;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            other.gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
