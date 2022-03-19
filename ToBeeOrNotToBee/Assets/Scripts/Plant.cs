using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantState
{
    Seed, 
    Stem, 
    Fruit
}

public class Plant : MonoBehaviour
{
    public PlantState state;
    public float growTime;
    private float remainingTime;
    public float value;
    private float quality;

    // Start is called before the first frame update
    void Start()
    {
        state = PlantState.Seed;
        remainingTime = growTime;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case PlantState.Seed:
                break;
            case PlantState.Stem:
                remainingTime -= Time.deltaTime;
                if (remainingTime < 0)
                {
                    state = PlantState.Fruit;
                    Destroy(gameObject.transform.Find("Stem"));
                    gameObject.transform.Find("Fruit").gameObject.SetActive(true);
                }
                break;
            case PlantState.Fruit:
                break;
        }
    }
}
