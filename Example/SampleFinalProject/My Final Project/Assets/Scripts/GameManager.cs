using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject dummyCar;
    [SerializeField] CarController carPrefab;
    [SerializeField] Transform carSpawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(carPrefab, carSpawnPoint.position, carSpawnPoint.rotation);
            dummyCar.SetActive(false);
        }
    }
}
