using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeLevel : MonoBehaviour
{

    public float bee_level;
    GameObject beecube;
    private float level_low;
    private float level_high;
    private float cube_y;
    GameObject bee1;
    GameObject bee2;
    GameObject bee3;
    GameObject bee4;
    GameObject bee5;

    // Start is called before the first frame update
    void Start()
    {
        bee_level = 20;
        level_low = 0.92f;
        level_high = 1.655f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Increase_Bees()
    {
        bee_level = bee_level + (100 - bee_level) / 10;
        cube_y = (bee_level * (level_high - level_low) + level_low);
        beecube.transform.position = new Vector3(0.0744f, cube_y, 0.1254f);

        // Adjust visible bees based on bee level
        if (bee_level > 0)
        {
            (bee1.GetComponent<MeshRenderer>()).enabled = true;
        }
        else
        {
            (bee1.GetComponent<MeshRenderer>()).enabled = false;
        }
        if (bee_level > 20)
        {
            (bee2.GetComponent<MeshRenderer>()).enabled = true;
        }
        else
        {
            (bee2.GetComponent<MeshRenderer>()).enabled = false;
        }
        if (bee_level > 40)
        {
            (bee3.GetComponent<MeshRenderer>()).enabled = true;
        }
        else
        {
            (bee3.GetComponent<MeshRenderer>()).enabled = false;
        }
        if (bee_level > 60)
        {
            (bee4.GetComponent<MeshRenderer>()).enabled = true;
        }
        else
        {
            (bee4.GetComponent<MeshRenderer>()).enabled = false;
        }
        if (bee_level > 80)
        {
            (bee5.GetComponent<MeshRenderer>()).enabled = true;
        }
        else
        {
            (bee5.GetComponent<MeshRenderer>()).enabled = false;
        }

    }

    public void Decrease_Bees(int decrease_bees_by)
    {
        bee_level = bee_level - decrease_bees_by;
        cube_y = (bee_level * (level_high - level_low) + level_low);
        beecube.transform.position = new Vector3(0.0744f, cube_y, 0.1254f);
    }
}
