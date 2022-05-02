using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Patroller : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject[] active_plants;
    
    public GameObject hiveTransform;
    public float height = 1;
    public int waypointIndex;

    private int speed;

    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(waypoints[waypointIndex].position);
        speed = 10;

        waypoints = new GameObject[10];

        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = null;
        }

        FindPlants();
        waypointIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FindPlants();
        Patrol();
    }

    void Patrol()
    {
        // If there are any more active plants, go to them
        if (active_plants.Length != 0)
        {
            if (!this.GetComponent<MeshRenderer>().enabled)
            {
                this.GetComponent<MeshRenderer>().enabled = true;
            }
            if(waypoints[waypointIndex] == null)
            {
                waypointIndex = 0;
                return;
            }

            Vector3 dir = Vector3.Normalize(waypoints[waypointIndex].transform.position - transform.position + new Vector3(0, height, 0));
            transform.Translate(dir * speed * Time.deltaTime / 10);

            float dist = Vector3.Distance(transform.position, waypoints[waypointIndex].transform.position + new Vector3(0, height, 0));
            if (dist < 0.05f)
            {
                if(waypointIndex != 0)
                {
                    waypoints[waypointIndex].transform.parent.gameObject.GetComponent<Plant>().Pollinate();
                }
                IncreaseIndex();
            }
        }
        else
        {
            float dist = Vector3.Distance(transform.position, hiveTransform.transform.position + new Vector3(0, height, 0));

            if (dist > 0.05f)
            {
                Vector3 dir = Vector3.Normalize(hiveTransform.transform.position - transform.position + new Vector3(0, height, 0));
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
        //transform.LookAt(waypoints[waypointIndex].transform.position);
    }

    // Finding the active plants ("stem" or "plant" tag)
    void FindPlants()
    {
        active_plants = GameObject.FindGameObjectsWithTag("Stem");

        waypoints[0] = hiveTransform;

        for (int i = 1; i < active_plants.Length + 1; i++)
        {
            waypoints[i] = active_plants[i-1];
        }

        for(int i = active_plants.Length + 1; i < waypoints.Length; i++)
        {
            waypoints[i] = null;
        }
    }
}