using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameSystem : MonoBehaviour
{
    public GameObject player;

    public GameObject introPanel;
    public GameObject endingPanel;
    public Transform startEndTransform;

    public InputActionReference endGame;

    public Transform stallTop;
    public GameObject[] Seeds;

    public Material NaturePackMaterial;
    public Material[] grayScaleMaterials;

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

    public void SpawnItem(string type)
    {
        if(type == "blueberry")
        {
            Instantiate(Seeds[0], stallTop.position, stallTop.rotation, null);
        }
        else if(type == "strawberry")
        {
            Instantiate(Seeds[1], stallTop.position, stallTop.rotation, null);
        }
        else if (type == "raspberry")
        {
            Instantiate(Seeds[2], stallTop.position, stallTop.rotation, null);
        }
    }

    public void grayScaleLevel(int percent)
    {
        //need to make copy of materials to keep track of the original looks
        foreach(Material mat in grayScaleMaterials)
        {
            Color temp = mat.color;
            float average = (temp.r + temp.g + temp.b) / 3;
            //mat.color;
        }
    }
}
