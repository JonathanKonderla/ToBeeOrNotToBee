using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSystem : MonoBehaviour
{
    public GameObject player;

    //public float maxGameTime = 120f;
    //private float gameTime = 0f;

    public GameObject introPanel;
    public GameObject endingPanel;
    public Transform startEndTransform;

    public InputActionReference endGame;

    public Transform stallTop;
    public GameObject[] Seeds;

    private void Awake()
    {
        if(endGame != null)
        {
            endGame.action.started += EndGame;
        }
    }

    private void OnDestroy()
    {
        if (endGame != null)
        {
            endGame.action.started -= EndGame;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EndGame(InputAction.CallbackContext context)
    {
        if (endingPanel != null)
        {
            endingPanel.SetActive(true);
        }

        player.transform.position = startEndTransform.position;
        player.transform.rotation = startEndTransform.rotation;

        //turn off locomotion
    }

    public void StartGame()
    {
        introPanel.SetActive(false);
    }

    public void SpawnSeed(string type)
    {
        //change type to enum

        Instantiate(Seeds[0], stallTop.position, stallTop.rotation, null);
    }
}
