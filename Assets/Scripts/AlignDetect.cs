using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Raycast Script Works!
public class AlignDetect : MonoBehaviour
{

    public GameObject pivotObject;

    public bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        float maxDistance = 10f;
        Ray aligningRay = new Ray(transform.position, pivotObject.transform.position - transform.position);

        Debug.DrawRay(transform.position, (pivotObject.transform.position - transform.position) * maxDistance, Color.white);

        if (Physics.Raycast(aligningRay, out hit, maxDistance))
        {
            isHit = true;
            if(hit.collider.tag == "planet")
            {
                Debug.DrawRay(transform.position, (pivotObject.transform.position - transform.position) * maxDistance, Color.red);
            }
        }
    }
}
