using TMPro;
using UnityEngine;

public class HighScore_Text : MonoBehaviour
{
    TMP_Text highScoreText;

    private void Awake()
    {
        highScoreText = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        UpdateScore();
        ScoreManager.Instance.OnHighScoreUpdate.AddListener(UpdateScore);
    }
    private void UpdateScore()
    {
        highScoreText.text = "high score " + ScoreManager.Instance.highScore;
    }
}
