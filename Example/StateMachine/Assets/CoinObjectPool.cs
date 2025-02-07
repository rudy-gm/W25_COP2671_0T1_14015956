using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObjectPool : ObjectPool<CoinPickup> {

    [SerializeField] List<CoinPickup> pickups;


    public override void InitializeAfterAwake()
    {
        PoolObjects(25, pickups);
    }
    private IEnumerator Start()
    {
        while (true)
        {
            var coin = GetPooledObject();
            coin.gameObject.SetActive(false);
            yield return new WaitForSeconds(2);

            coin.transform.position = new Vector3(0, 0.08f, 16.69f);
            coin.gameObject.SetActive(true);
            yield return null;
        }
    }


}
