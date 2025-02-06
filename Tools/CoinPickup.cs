using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int coinValue;
    AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _audioSource.volume = 0.5f;
        _audioSource.Play();        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerPiece playerPiece))
        {
            ScoreManager.Instance.AddScore(coinValue);            
            SoundManager.Instance.PlayCoinCollectedSound();
            CoinObjectPool.Instance.ReturnObjectToPool(this);
        }
    }
}
