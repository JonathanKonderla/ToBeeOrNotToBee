using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPlot : MonoBehaviour
{
    private bool isEmpty = true;
    private bool isPlowed = false;

    public Material unplowedMat;
    public Material plowedMat;


    private void OnTriggerEnter(Collider other)
    {
        print("trigger");
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
}
