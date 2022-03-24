using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;
    public float height = 1;

    public int waypointIndex;

    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        //transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position + new Vector3(0, height, 0));
        if(dist < 0.05f)
        {
            IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
        Vector3 dir = Vector3.Normalize(waypoints[waypointIndex].position - transform.position + new Vector3(0, height, 0));
        transform.Translate(dir * speed * Time.deltaTime / 10);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        //transform.LookAt(waypoints[waypointIndex].position);
    }
}
