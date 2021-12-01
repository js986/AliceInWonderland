using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject[] solution;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwapPlanets(int a, int b)
    {
        Vector3 temp = planets[a].transform.position;
        GameObject tempObj = planets[a];
        planets[a].transform.position = planets[b].transform.position;
        planets[b].transform.position = temp;
        planets[a] = planets[b];
        planets[b] = tempObj;
    }


    bool IsCorrect()
    {
        for (int i = 0; i < solution.Length; i++)
        {
            if (planets[i] != solution[i])
                return false;
        }
        return true;
    }
}
