using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject package;
    private float spawnIntervals;
    [SerializeField] private float spawnTimer = 1f;
    [SerializeField] Transform[] spawnLocations;
    [SerializeField] Transform[] speedspawnLocations;
    DriverController dc;
    bool canSpawn = false;

    private void Awake()
    {
        dc = GetComponent<DriverController>();
    }
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

    public void Spawn()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= 5f)
        {
            
          spawnTimer = spawnIntervals;
          Instantiate(package, spawnLocations[Random.Range(0, spawnLocations.Length - 1)].position, Quaternion.identity);         
                      
        }

    }
}
