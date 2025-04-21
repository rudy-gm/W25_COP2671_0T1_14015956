using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.AppUI.UI;
using   TMPro;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    
    public ObstacleSpawner obstacleSpawner; 
    public Transform ball;
    public Transform ballSpawnPoint;
    public int score = 0; 
    public TextMeshProUGUI scoreText;
    public bool isGameRunning = false;
    public float resetDelay = 0.5f; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        isGameRunning = false;
        obstacleSpawner.enabled = false;
        Time.timeScale = 0;

    }

    public void OnGoalScored(){

        score += 1; 
        Debug.Log("Score: " + score);
        updaScoreText();

        StartCoroutine(ResetBallAfterDelay());
        obstacleSpawner.SpawnObstacles(); 
    }

    private IEnumerator ResetBallAfterDelay(){
        yield return new WaitForSeconds(resetDelay); // Wait for the specified delay

        ResetBallPosition(); // Reset the ball position
    }

    private void ResetBallPosition(){
        ball.position = ballSpawnPoint.position;

        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>(); 

        if(ballRigidbody !=null){
            ballRigidbody.linearVelocity = Vector3.zero; 
            ballRigidbody.angularVelocity = Vector3.zero; 
        }

    }

    private void updaScoreText(){
        scoreText.text = "Score: " + score.ToString(); 
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
