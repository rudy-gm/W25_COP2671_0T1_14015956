using UnityEngine;

public class CarrotPowerUp : PowerUp
{
    public override void Process()
    {
        base.SetPowerDownTime(3);
        transform.localScale += Vector3.one;
        base.Process();
    }
    public override void Cleanup()
    {
        transform.localScale = Vector3.one;
    }
}
