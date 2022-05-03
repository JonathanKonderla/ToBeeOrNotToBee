using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeSign : MonoBehaviour
{
    public float bee_level;
    public GameObject beecube;
    private float level_low;
    private float level_high;
    private float cube_y;

    // Start is called before the first frame update
    void Start()
    {
        level_low = 0.009f;
        level_high = 0.016f;
    }

    void Update()
    {
        // Percent Bee Level * (Possible Range) + Lowest Y Coordinate
        cube_y = (0.01f * bee_level * (level_high - level_low) + level_low);
        Vector3 goalpos = new Vector3(-0.001f, cube_y, 0f);
        float dist = Vector3.Distance(transform.position, goalpos);

        if (dist > 0.001f)
        {
            var step = Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, goalpos, step);
        }
        //beecube.transform.localPosition = new Vector3(-0.001f, cube_y, 0.0f);
    }

}
