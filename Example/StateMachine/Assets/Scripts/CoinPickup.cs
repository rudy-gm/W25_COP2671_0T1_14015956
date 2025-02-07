using System.Collections;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int coinValue;
    //private void Awake()
    //{
    //}

    // private void OnEnable()
    // {
    //     _audioSource.volume = 0.5f;
    //     _audioSource.Play();        
    // }

    private void OnEnable()
    {
        StartCoroutine(ReturnObject());
    }


    private IEnumerator ReturnObject()
    {
        yield return new WaitForSeconds(3);
        CoinObjectPool.Instance.ReturnObjectToPool(this);
        yield return null;
    }



    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.TryGetComponent(out PlayerPiece playerPiece))
    //    {
    //        // ScoreManager.Instance.AddScore(coinValue);            
    //        // SoundManager.Instance.PlayCoinCollectedSound();
    //        CoinObjectPool.Instance.ReturnObjectToPool(this);
    //    }
    //}
}
