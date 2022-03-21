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
    private GameObject seed;
    private GameObject stem;
    private GameObject fruit;

    public PlantState state;
    public float growTime;
    private float remainingTime;
    public float value;
    private float quality;

    private void Awake()
    {
        seed = gameObject.transform.GetChild(0).gameObject;
        stem = gameObject.transform.GetChild(1).gameObject;
        fruit = gameObject.transform.GetChild(2).gameObject;
    }

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
                    Destroy(stem);
                    fruit.SetActive(true);
                }
                break;
            case PlantState.Fruit:
                break;
        }
    }

    public void PlantSeed()
    {
        Destroy(seed);
        state = PlantState.Stem;
        GetComponent<Rigidbody>().isKinematic = true;
        stem.SetActive(true);
    }
}
