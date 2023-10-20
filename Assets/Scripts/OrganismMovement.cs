using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganismMovement : MonoBehaviour
{
    [SerializeField] bool Variety1;
    [SerializeField] bool Variety2;

    void FixedUpdate()
    {
        if (Variety2 == true) 
        { 
            transform.position = transform.position + new Vector3(Random.Range(-.02f, .02f), Random.Range(-.02f, .02f), Random.Range(0, 0)); 
        }
          
        if (Variety1 == true)
        {
            transform.position = transform.position + new Vector3(Random.Range(-.05f, .05f), Random.Range(-.05f, .05f), Random.Range(0, 0));

            // should probably make it so the things cant look bad
            transform.localScale = transform.localScale + new Vector3(Random.Range(-.002f, .002f), Random.Range(-.002f, .002f), 0);
        }
    }
}
