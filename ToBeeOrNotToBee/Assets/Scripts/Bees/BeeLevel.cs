using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeLevel : MonoBehaviour
{

    public float bee_level;
    public GameObject bee1;
    public GameObject bee2;
    public GameObject bee3;
    public GameObject bee4;
    public GameObject bee5;

    // Start is called before the first frame update
    void Start()
    {
        bee_level = 10;
    }

    public void Increase_Bees()
    {
        bee_level = bee_level + (100 - bee_level) / 10;
        Bee_Display();
    }

    public void Decrease_Bees(int decrease_bees_by)
    {
        bee_level = bee_level - decrease_bees_by;
        Bee_Display();
    }

    public void Bee_Display()
    {
        // Adjust visible bees based on bee level
        if (bee_level > 0)
        {
            bee1.SetActive(true);
        }
        else
        {
            bee1.SetActive(false);
        }
        if (bee_level > 20)
        {
            bee2.SetActive(true);
        }
        else
        {
            bee2.SetActive(false);
        }
        if (bee_level > 40)
        {
            bee3.SetActive(true);
        }
        else
        {
            bee3.SetActive(false);
        }
        if (bee_level > 60)
        {
            bee4.SetActive(true);
        }
        else
        {
            bee4.SetActive(false);
        }
        if (bee_level > 80)
        {
            bee5.SetActive(true);
        }
        else
        {
            bee5.SetActive(false);
        }
    }
}
