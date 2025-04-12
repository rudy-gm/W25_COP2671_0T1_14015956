using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameTimer : MonoBehaviour
{

    public float gameTime = 60f; 
    public TextMeshProUGUI timerText;

    private bool gameOver = false; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!gameOver){
            gameTime -= Time.deltaTime; 

            timerText.text = "Time: " + Mathf.CeilToInt(gameTime).ToString(); 

            if(gameTime <= 0f){

                gameTime = 0f; 
                gameOver = true; 
                EndGame(); 
            }
        }


    }

    void EndGame(){

        Debug.Log("Game Over! Final Score: " + FindObjectOfType<GameManager>().score); 

    }
}
