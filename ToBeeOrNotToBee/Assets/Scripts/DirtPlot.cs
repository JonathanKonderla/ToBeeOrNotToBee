using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPlot : MonoBehaviour
{
    private enum PlotState
    {
        Empty,
        Growing,
        Pick
    }

    private PlotState state;

    // Start is called before the first frame update
    void Start()
    {
        state = PlotState.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case PlotState.Empty:
                break;
            case PlotState.Growing:
                break;
            case PlotState.Pick:
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger");
        if(state == PlotState.Empty && other.gameObject.CompareTag("Seed"))
        {
            GameObject plant = other.gameObject.transform.parent.gameObject;
            Destroy(other.gameObject);
            plant.GetComponent<Plant>().state = PlantState.Stem;
            plant.GetComponent<Rigidbody>().isKinematic = true;
            plant.transform.position = this.transform.position;
            plant.transform.Find("Stem").gameObject.SetActive(true);
            state = PlotState.Growing;
        }
    }
}
