using System.Collections;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject[] objects;

    void Start ()
    {
        objects = GameObject.FindGameObjectsWithTag("Object");
        
        for(int i = 0; i < 1; i++)
        {
            Debug.Log("Object Number "+i+" is named "+objects[i].name);
        }
        for(int i = 0; i < 2; i++)
        {
            Debug.Log("Object Number "+i+" is named "+objects[i].name);
        }
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("Object Number "+i+" is named "+objects[i].name);
        }
    }
}
