using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AntidoteSeek : MonoBehaviour
{
    Spawn spawn;

    private void Start()
    {
        GameObject spawner = GameObject.Find("Spawner");
        spawn = spawner.GetComponent<Spawn>();
    }

    void FixedUpdate()
    {
        if (spawn.GoodOnes.Length > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, spawn.GoodOnes[spawn.Target].transform.position, 0.05f);
        }
    }
}
