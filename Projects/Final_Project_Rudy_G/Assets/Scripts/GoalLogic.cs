using UnityEngine;

public class GoalLogic : MonoBehaviour
{

    public AudioSource audioSource; 
    public AudioClip goalSound;
    public ParticleSystem goalParticles; 

    private void OnTriggerEnter(Collider other){
        
        if(other.CompareTag("Player")){

            audioSource.PlayOneShot(goalSound);
            goalParticles.Play();

            FindObjectOfType<GameManager>().OnGoalScored(); 
        }

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
