using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPlot : MonoBehaviour
{
    private enum State
    {
        Empty, 
        Growing, 
        Pick
    }

    private State state;

    // Start is called before the first frame update
    void Start()
    {
        state = State.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Empty:
                break;
            case State.Growing:
                break;
            case State.Pick:
                break;
        }
    }
}
