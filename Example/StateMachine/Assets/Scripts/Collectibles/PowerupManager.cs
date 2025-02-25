using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PowerUp powerUp))
        {
            gameObject.AddComponent(powerUp.GetType());
            Debug.Log(gameObject.name);

            Debug.Log(powerUp.name);
            powerUp.Process();

            //var newPowerup = GetComponent<PowerUp>();
            //newPowerup.Process();


            Destroy(powerUp.gameObject, 05f);
        }            
    }
}
