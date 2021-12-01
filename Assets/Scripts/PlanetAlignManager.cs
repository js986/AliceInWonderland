using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAlignManager : MonoBehaviour
{

    GameObject[] planets;

    private bool allAligned;

    // Start is called before the first frame update
    void Start()
    {
       planets = GameObject.FindGameObjectsWithTag("planet");
    }

    // Update is called once per frame
    void Update()
    {

        planets = GameObject.FindGameObjectsWithTag("planet");
        foreach (GameObject planet in planets)
        {
            if (!planet.GetComponent<AlignDetect>().isHit)
            {
                allAligned = false;
                break;
            }
            else
            {
                allAligned = true;
            }
        }
        if (allAligned == true)
        {
            PauseGame();
            Debug.Log("YOU WIN THE GAME!!!");
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        //Disable scripts that still work while timescale is set to 0
    }
}
