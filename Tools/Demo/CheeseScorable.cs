using UnityEngine;

public class CheeseScorable : Scorable
{
    private void Awake()
    {
        scoreType = ScoreTypes.Cheese;
        scoreValue = 50;
    }
    public override void Collect()
    {
        Debug.Log("Cheese Collect");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerPiece player))
        {
            Collect();
            Destroy(player);
            Destroy(this);
        }
    }
}
