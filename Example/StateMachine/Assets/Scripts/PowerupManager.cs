using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PowerUp powerUp))
        {
            gameObject.AddComponent(powerUp.GetType());
            var newPowerup = GetComponent<PowerUp>();
            newPowerup.Process();


            Destroy(powerUp.gameObject);
        }            
    }
}
