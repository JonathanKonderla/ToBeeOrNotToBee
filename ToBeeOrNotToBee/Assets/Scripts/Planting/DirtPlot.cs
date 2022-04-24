using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPlot : MonoBehaviour
{
    private float weedRadius = 0.25f;
    public bool isPlowed = false;
    public bool hasWeeds = false;
    public bool hasBugs = false;

    public Material unplowedMat;
    public Material plowedMat;

    private bool isEmpty = true;
    private GameObject plant;

    public void WeedPlot(GameObject weed)
    {
        //position random theta
        Instantiate(weed, this.transform.position + new Vector3(weedRadius * Mathf.Cos(Random.Range(0, 2 * Mathf.PI)), 0, weedRadius * Mathf.Sin(Random.Range(0, 2 * Mathf.PI))), Quaternion.identity);
        hasWeeds = true;
    }

    private void Update()
    {
        if (!isEmpty && hasWeeds)
        {
            plant.GetComponent<Plant>().SetHasWeeds(hasWeeds);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isEmpty && isPlowed && other.gameObject.CompareTag("Seed"))
        {
            plant = other.gameObject.transform.parent.gameObject;
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
            plant = other.gameObject.transform.parent.gameObject;
            plant.GetComponent<Rigidbody>().isKinematic = false;
            isEmpty = true;
            isPlowed = false;
            GetComponent<MeshRenderer>().material = unplowedMat;
            plant.GetComponent<Plant>().timer.gameObject.SetActive(false);
        }
    }
}
