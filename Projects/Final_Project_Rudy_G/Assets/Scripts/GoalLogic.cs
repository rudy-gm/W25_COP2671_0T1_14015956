using UnityEngine;
using System.Collections;

public class GoalLogic : MonoBehaviour
{

    public AudioSource audioSource; 
    public AudioClip goalSound;
    public ParticleSystem goalParticles; 
    public float particleDuration = 2f; // Duration for the particle system to play

    private void OnTriggerEnter(Collider other){
        
        if(other.CompareTag("Player")){

            audioSource.PlayOneShot(goalSound);
            goalParticles.Play();

            StartCoroutine(StopParticlesAfterDelay());

            FindFirstObjectByType<GameManager>().OnGoalScored(); 
        }


    }
    private IEnumerator StopParticlesAfterDelay(){
        yield return new WaitForSeconds(particleDuration); // Wait for the specified duration
        goalParticles.Stop(); // Stop the particle system
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
