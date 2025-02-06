using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{   
    [SerializeField] private AudioClip _coinCollectedClip;    
    [SerializeField] private AudioSource _audioSource;
    
    public void PlayCoinCollectedSound()
    {   
        _audioSource.PlayOneShot(_coinCollectedClip);        
    }
}
