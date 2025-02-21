using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public UnityEvent<int> OnScoreUpdate;
    public UnityEvent OnHighScoreUpdate;
    public int totalCoins;
    public int highScore;

    private void Start()
    {
        highScore = GameManager.Instance.highScore;
        OnScoreUpdate.AddListener(UpdateScore);
    }
    private void UpdateScore(int coinValue)
    {
        totalCoins += coinValue;
        if (totalCoins > highScore)
        {
            highScore += coinValue;
        }
    }    
}
