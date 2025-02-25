using System.Collections;
using UnityEngine;

public class CoinPickup : PowerUp
{
    [SerializeField] int coinValue;
       

    public override void Process()
    {        
        ScoreManager.Instance.OnScoreUpdate.Invoke(coinValue);
        base.Process();
    }

    public override void Cleanup()
    {
        base.Cleanup();
    }
}
