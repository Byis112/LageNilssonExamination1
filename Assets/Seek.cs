using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    [SerializeField] GameObject Player;
    void Update()
    {
        // CHALLENGE: This could be more efficient
        GameObject moveTowardsThis = Player;
        transform.position = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, 0.005f);
        // put in player's position
    }
}
