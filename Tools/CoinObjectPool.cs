using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObjectPool : ObjectPool<CoinPickup>
{
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
            var x = Random.Range(0, 8);
            var z = Random.Range(0, 8);
            coin.transform.position = new Vector3(x, 0, z);
            coin.gameObject.SetActive(true);
            yield return null;
        }        
    }
}
