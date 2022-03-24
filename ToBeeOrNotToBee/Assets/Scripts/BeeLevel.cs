using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeLevel : MonoBehaviour
{

    public int bee_level;
    public Text bee_level_text;

    // Start is called before the first frame update
    void Start()
    {
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Increase_Bees()
    {
        bee_level = bee_level + (100 - bee_level)/10;
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
    }

    public void Decrease_Bees(int decrease_bees_by)
    {
        bee_level = bee_level - decrease_bees_by;
        bee_level_text.text = "Bee Level: " + bee_level.ToString();
    }
}
