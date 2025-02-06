using TMPro;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] int totalScore = 0;

    public override void InitializeAfterAwake()
    {
        AddScore(10);
    }

    public void AddScore(int scoreAmount)
    {
        totalScore += scoreAmount;

        if (scoreText != null) 
            scoreText.text = $"Score {totalScore}";
    }
}
