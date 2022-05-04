using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeLevel : MonoBehaviour
{

    public float bee_level;

    public GameObject beecube;
    private float level_low;
    private float level_high;
    private float cube_y;

    public GameObject bee1;
    public GameObject bee2;
    public GameObject bee3;
    public GameObject bee4;
    public GameObject bee5;

    private AudioSource audioSource;
    public AudioClip happySound;
    public AudioClip sadSound;

    // Start is called before the first frame update
    void Start()
    {
        bee_level = 10;
        level_low = 0.009f;
        level_high = 0.016f;
        audioSource = GetComponent<AudioSource>();
    }

    public void Increase_Bees()
    {
        bee_level = bee_level + (100 - bee_level) / 10;
        cube_y = (0.01f * bee_level * (level_high - level_low) + level_low);
        beecube.transform.localPosition = new Vector3(-0.001f, cube_y, 0.0f);
        audioSource.PlayOneShot(happySound);
        Bee_Display();
    }

    public void Decrease_Bees(int decrease_bees_by)
    {
        bee_level = bee_level - decrease_bees_by;
        bee_level = Mathf.Clamp(bee_level, 0, 100);
        cube_y = (bee_level * (level_high - level_low) + level_low);
        beecube.transform.localPosition = new Vector3(-0.001f, cube_y, 0.0f);
        audioSource.PlayOneShot(sadSound);
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
