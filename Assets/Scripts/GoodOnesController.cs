using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodOnesController : MonoBehaviour
{
    Vector3 SizeLimit;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Virus")
        {
            Destroy(other.gameObject);
            if (transform.localScale.x < 3 && transform.localScale.y < 3)
            {
                transform.localScale += new Vector3(.5f, .5f, 0);
            }
        }

        if (other.gameObject.tag == "Antidote")
        {
            Destroy(other.gameObject);
            if (transform.localScale.x > 0.1 && transform.localScale.y > 0.1)
            {
                transform.localScale -= new Vector3(.5f, .5f, 0);
            }
        }
    }

    void FixedUpdate()
    {
        transform.localScale = transform.localScale + new Vector3(Random.Range(-.002f, .002f), Random.Range(-.002f, .002f), 0);
        transform.position = transform.position + new Vector3(Random.Range(-.01f,.01f), Random.Range(-.01f,.01f), Random.Range(0,0));
        transform.Translate(.02f, 0, 0 * .1f);
        transform.Rotate(0, 0, .2f, Space.Self);
    }
}
