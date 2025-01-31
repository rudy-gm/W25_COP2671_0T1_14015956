using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    float powerupExtinguishTime = 1;

    public virtual void SetPowerDownTime(float time)
    {
        powerupExtinguishTime = time;
    }
    public virtual void Process() 
    {
        StartCoroutine(DestroyPowerupCo());
    }
    public virtual void Cleanup() { }

    private IEnumerator DestroyPowerupCo()
    {
        yield return new WaitForSeconds(powerupExtinguishTime);
        Cleanup();
        Destroy(this);
    }
}
