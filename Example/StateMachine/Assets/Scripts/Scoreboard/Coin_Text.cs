using TMPro;
using UnityEngine;

public class Coin_Text : MonoBehaviour
{   
    TMP_Text coinText;

    private void Awake()
    {
        coinText = GetComponent<TMP_Text>();
    }
    private void Start()
    { 
        UpdateScore(0);
        ScoreManager.Instance.OnScoreUpdate.AddListener(UpdateScore);
    }
    private void UpdateScore(int totalCoins)
    {
        coinText.text = "coins " + ScoreManager.Instance.totalCoins;
    }
}
