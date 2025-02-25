using UnityEngine;

public class CollissionObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out CarController carController))
        {
            Debug.Log("Collission " + gameObject.name);
        }
    }
}
