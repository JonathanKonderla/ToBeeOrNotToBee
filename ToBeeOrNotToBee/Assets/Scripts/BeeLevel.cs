using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeLevel : MonoBehaviour
{

    public float bee_level;
    public Text bee_level_text;
    GameObject beecube;
    private float level_low;
    private float level_high;
    private float cube_y;

    // Start is called before the first frame update
    void Start()
    {
        bee_level = 20f;
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
        level_low = 0.92f;
        level_high = 1.655f;
    }

    // Update is called once per frame
    void Update()
    {
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
    }

    public void Increase_Bees()
    {
        bee_level = bee_level + (100 - bee_level)/10;
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
        cube_y = (bee_level * (level_high - level_low) + level_low);
        beecube.transform.position = new Vector3(0.0744f, cube_y, 0.1254f);
        
    }

    public void Decrease_Bees(int decrease_bees_by)
    {
        bee_level = bee_level - decrease_bees_by;
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
        cube_y = (bee_level * (level_high - level_low) + level_low);
        beecube.transform.position = new Vector3(0.0744f, cube_y, 0.1254f);
    }
}
