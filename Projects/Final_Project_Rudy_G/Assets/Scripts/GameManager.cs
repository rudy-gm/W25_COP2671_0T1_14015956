using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class GameManager : MonoBehaviour
{
    
    public ObstacleSpawner obstacleSpawner; 
    public Transform ball;
    public Transform ballSpawnPoint;
    public int score = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        obstacleSpawner.SpawnObstacles(); 
        ResetBallPosition(); 

    }

    public void OnGoalScored(){

        score += 1; 
        Debug.Log("Score: " + score); 

        ResetBallPosition(); 
        obstacleSpawner.SpawnObstacles(); 
    }

    private void ResetBallPosition(){
        ball.position = ballSpawnPoint.position;

        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>(); 

        if(ballRigidbody !=null){
            ballRigidbody.linearVelocity = Vector3.zero; 
            ballRigidbody.angularVelocity = Vector3.zero; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
