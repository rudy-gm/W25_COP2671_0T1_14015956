using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public int numberOfObstacles = 10;
    public Vector3 spawnAreaSize = new Vector3(40f, 0f, 30f);
    public Transform spawnAreaCenter; 

    private List<GameObject> spawnedObstacles = new List<GameObject>();

    public void SpawnObstacles()
    {
        foreach (GameObject obstacle in spawnedObstacles)
        {
            Destroy(obstacle); 
        }

        spawnedObstacles.Clear();

        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnAreaCenter.position.x - spawnAreaSize.x / 2, spawnAreaCenter.position.x + spawnAreaSize.x / 2), // Wider X range
                spawnAreaCenter.position.y, // Maintain Y position
                Random.Range(spawnAreaCenter.position.z - spawnAreaSize.z / 2, spawnAreaCenter.position.z + spawnAreaSize.z / 2) // Deeper Z range
            );

            GameObject newObstacle = Instantiate(obstaclePrefab, randomPosition, Quaternion.Euler(0,90,0));
            spawnedObstacles.Add(newObstacle);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
