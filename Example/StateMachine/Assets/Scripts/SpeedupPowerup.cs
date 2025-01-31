using UnityEngine;

public class SpeedupPowerup : PowerUp
{
    float currentSeed;
    public override void Process()
    {
        currentSeed = GameManager.Instance.speed;
        GameManager.Instance.speed = currentSeed * 1.3f;
        base.Process();
    }
    public override void Cleanup()
    {
        GameManager.Instance.speed = currentSeed;
    }
}
