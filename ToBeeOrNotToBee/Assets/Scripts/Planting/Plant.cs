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
    [SerializeField]
    private GameObject seed;
    [SerializeField]
    private GameObject stem;
    [SerializeField]
    private GameObject fruit;
    [SerializeField]
    public Renderer timer;

    public PlantState state;
    public float growTime;
    private float remainingTime;
    public float value;
    private float quality = 1;

    private bool hasWeeds;
    private bool hasBugs = false;
    private float bugChance = 0.05f;
    public GameObject bug;
    public GameObject bugScene;

    private Color red = new Color(0.922f, 0.136f, 0.137f);
    private Color green = new Color(0.137f, 0.922f, 0.137f);

    public void SetHasWeeds(bool b)
    {
        hasWeeds = b;
    }

    public void Pollinate()
    {
        quality += 0.1f;
    }

    private void BugChance()
    {
        if (Random.value < bugChance)
        {
            if (hasBugs == false)
            {
                BugPlant();
            }
        }
    }

    private void BugPlant()
    {
        hasBugs = true;
        bugScene = Instantiate(bug, this.transform.position + new Vector3(0.25f * Mathf.Cos(Random.Range(0, 2*Mathf.PI)), 0, 0.25f * Mathf.Sin(Random.Range(0, 2 * Mathf.PI))), Quaternion.identity, this.transform);
        CancelInvoke();
    }

    public void DebugPlant()
    {
        hasBugs = false;
        Destroy(bugScene);
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
                remainingTime -= Time.deltaTime * (hasWeeds ? 0.5f : 1.0f);
                timer.material.color = Color.Lerp(green, red, remainingTime / growTime);
                if (hasBugs)
                    quality -= Time.deltaTime * 0.01f;
                if (remainingTime < 0)
                {
                    state = PlantState.Fruit;
                    Destroy(stem);
                    fruit.SetActive(true);
                    GetComponent<Rigidbody>().isKinematic = false;
                    GetComponent<Rigidbody>().useGravity = false;
                }
                break;
            case PlantState.Fruit:
                timer.material.color = green;
                break;
        }
    }

    public void PlantSeed()
    {
        Destroy(seed);
        state = PlantState.Stem;
        timer.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;
        stem.SetActive(true);
        InvokeRepeating("BugChance", 0, 1);
    }

    public void SellPlant(){
        print("destroying object");
        Destroy(this.gameObject);
    }

    public float GetValue()
    {
        quality = Mathf.Clamp(quality, 0.75f, 2.0f);
        return Mathf.Ceil(value * quality);
    }
}
