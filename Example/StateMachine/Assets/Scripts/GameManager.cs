using UnityEngine;
using UnityEngine.Events;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public float speed;
    public int highScore;

    public override void InitializeAfterAwake()
    {
        //PlayerPrefs.SetInt(nameof(highScore), highScore);
        //PlayerPrefs.SetFloat(nameof(speed), speed);


        highScore = PlayerPrefs.GetInt(nameof(highScore));
        speed = PlayerPrefs.GetFloat(nameof(speed));
    }
    public void StartGame() { Debug.Log("Start"); }
    public void StopGame() { }// playerPrefs 


}
