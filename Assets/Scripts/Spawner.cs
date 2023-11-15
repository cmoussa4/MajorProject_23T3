using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject package;
    private float yPosition;
    private float xPosition;
    private float spawnIntervals;
    [SerializeField] private float spawnTimer = 1f;
    [SerializeField] Transform[] spawnLocations;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= 10f)
        {
            spawnTimer = spawnIntervals;
            Instantiate(package,spawnLocations[Random.Range(0,spawnLocations.Length-1)].position, Quaternion.identity);
        }
    }
}
