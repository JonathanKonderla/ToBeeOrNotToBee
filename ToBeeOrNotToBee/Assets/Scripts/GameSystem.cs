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

    public Transform seedSpawn;
    public Transform toolSpawn;
    public GameObject[] Seeds;

    public int grayLevel;
    public Material NaturePackMaterial;
    public Material[] grayScaleMaterials;
    private Material[] originalColors;

    private void Awake()
    {
        if(endGame != null)
        {
            endGame.action.started += EndGame;
        }
    }

    private void Start()
    {
        originalColors = new Material[grayScaleMaterials.Length+1];
        originalColors[0] = NaturePackMaterial;
        grayScaleMaterials.CopyTo(originalColors, 1);
    }

    private void OnDestroy()
    {
        if (endGame != null)
        {
            endGame.action.started -= EndGame;
        }
    }

    private void Update()
    {
        //grayScaleLevel(grayLevel);
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
            Instantiate(Seeds[0], seedSpawn.position, seedSpawn.rotation, null);
        }
        else if(type == "strawberry")
        {
            Instantiate(Seeds[1], seedSpawn.position, seedSpawn.rotation, null);
        }
        else if (type == "raspberry")
        {
            Instantiate(Seeds[2], seedSpawn.position, seedSpawn.rotation, null);
        }
        else if (type == "pesticide")
        {
            Instantiate(Seeds[3], toolSpawn.position, toolSpawn.rotation, null);
        }
        else if (type == "natural")
        {
            Instantiate(Seeds[4], toolSpawn.position, toolSpawn.rotation, null);
        }
    }

    public void grayScaleLevel(int percent)
    {
        float natureLerp = Mathf.Lerp(255 / 255, 150 / 255, percent);
        NaturePackMaterial.color = new Color(natureLerp, natureLerp, natureLerp);

        for(int i = 0; i < grayScaleMaterials.Length; i++)
        {
            Color temp = originalColors[i].color;
            float average = (temp.r + temp.g + temp.b) / 3;
            
            grayScaleMaterials[i].color = new Color(Mathf.Lerp(temp.r, average, percent)/255, Mathf.Lerp(temp.g, average, percent)/255, Mathf.Lerp(temp.b, average, percent)/255);
        }
    }
}
