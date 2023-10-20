using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPoints;
    [SerializeField] GameObject Antidote;
    [SerializeField] GameObject RedVirus;
    public GameObject Player;
    public GameObject[] GoodOnes;

    public int Target;

    void Start()
    {
        InvokeRepeating("StartCoroutines", 3f, 3f);
    }

    private void Awake()
    {
        System.Random randomGen = new System.Random();
        Target = randomGen.Next(0, 3);

        if (GoodOnes.Length < 1)
        {
            GoodOnes = GameObject.FindGameObjectsWithTag("GoodOnes");
        }
    }

    void StartCoroutines()
    {
        StartCoroutine(SpawnAntidoteRepeatedly());
        StartCoroutine(SpawnRedVirusRepeatedly());
    }

    private IEnumerator SpawnAntidoteRepeatedly()
    {
        while (true)
        {
            int spawnPointIndex = Random.Range(0, SpawnPoints.Length);
            Instantiate(Antidote, SpawnPoints[spawnPointIndex].position, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }

    private IEnumerator SpawnRedVirusRepeatedly()
    {
        while (true)
        {
            int spawnPointIndex = Random.Range(0, SpawnPoints.Length);
            Instantiate(RedVirus, SpawnPoints[spawnPointIndex].position, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}
