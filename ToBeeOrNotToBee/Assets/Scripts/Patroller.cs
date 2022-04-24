using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Patroller : MonoBehaviour
{
    public Transform[] waypoints;
    public GameObject[] active_plants1;
    public GameObject[] active_plants2;
    public GameObject[] active_plants;
    
    public Transform hiveTransform;
    public float height = 1;
    public int waypointIndex;

    private int speed;

    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(waypoints[waypointIndex].position);
        speed = 10;
        FindPlants();
        waypointIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
        FindPlants();
    }

    void Patrol()
    {
        // If there are any more active plants, go to them
        if (active_plants.Length != 0)
        {
            Vector3 dir = Vector3.Normalize(waypoints[waypointIndex].position - transform.position + new Vector3(0, height, 0));
            transform.Translate(dir * speed * Time.deltaTime / 10);

            float dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position + new Vector3(0, height, 0));
            if (dist < 0.05f)
            {
                IncreaseIndex();
            }
        }
        else
        {
            float dist = Vector3.Distance(transform.position, hiveTransform.position + new Vector3(0, height, 0));

            if (dist > 0.05f)
            {
                Vector3 dir = Vector3.Normalize(hiveTransform.position - transform.position + new Vector3(0, height, 0));
                transform.Translate(dir * speed * Time.deltaTime / 10);
            }
            else
            {
                (this.GetComponent<MeshRenderer>()).enabled = false;
            }
        }
    }

    // The bees switch to the next waypoint / plant
    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        waypointIndex = Random.Range(0, waypoints.Length);
        transform.LookAt(waypoints[waypointIndex].position);
    }

    // Finding the active plants ("stem" or "plant" tag)
    void FindPlants()
    {
        active_plants = GameObject.FindGameObjectsWithTag("Stem");
        active_plants1 = GameObject.FindGameObjectsWithTag("Stem");
        active_plants2 = GameObject.FindGameObjectsWithTag("Fruit");

        active_plants = active_plants1.Concat(active_plants2).ToArray();

        if (active_plants.Length != 0)
        {
            waypoints = new Transform[active_plants.Length];
        }
    }
}
