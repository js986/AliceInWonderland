using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{

    public GameObject pivotObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDrawGizmos()
    {
        float maxDistance = 10000f;
        RaycastHit hit;

        bool isHit = Physics.Raycast(transform.position, pivotObject.transform.position - transform.position, out hit, maxDistance);
        if (isHit)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, (pivotObject.transform.position - transform.position) * hit.distance);
        }
        else
        {
            Gizmos.color = Color.white;
            Gizmos.DrawRay(transform.position, (pivotObject.transform.position - transform.position) * maxDistance);
        }
    }
}
