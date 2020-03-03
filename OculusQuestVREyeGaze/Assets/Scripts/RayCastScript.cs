using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    // Start is called before the first frame update

    Ray ray; 
    RaycastHit hit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag=="Object")
            {
            Debug.Log(hit.collider.name);
            }
        }

        Debug.DrawRay(transform.position,transform.forward*1000.0f,Color.red);
    }
}
