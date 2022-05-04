using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupPlot : MonoBehaviour
{
    public GameObject weedPrefab;
    public DirtPlot[] plots;
    public float weedChance = 0.001f;

    private void Start()
    {
        InvokeRepeating("WeedChance", 0, 1);
    }

    // Update is called once per frame
    private void WeedChance()
    {
        if (Random.value < weedChance)
        {
            int weedPlot = Random.Range(0, plots.Length);
            if (plots[weedPlot].hasWeeds == false && plots[weedPlot].canWeed == true)
            {
                plots[weedPlot].WeedPlot(weedPrefab);
            }
        }
    }
}
