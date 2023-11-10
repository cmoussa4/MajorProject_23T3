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
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= 5f)
        {
            spawnTimer = spawnIntervals;
            yPosition = Random.Range(-8.5f, 8.5f);
            xPosition = Random.Range(-15f, 15f);
            Vector3 randomspawn = new Vector3(xPosition, yPosition, 0.0f);
            Instantiate(package, randomspawn, Quaternion.identity);
        }
    }
}
