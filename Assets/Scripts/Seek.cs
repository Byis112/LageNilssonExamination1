using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    void FixedUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }

        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.05f);
        }
    }
}
