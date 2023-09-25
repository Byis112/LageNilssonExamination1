using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    void Update()
    {
        GameObject camera = Player;
        transform.position = camera.transform.position + new Vector3(0,0,-10);
    }
}
