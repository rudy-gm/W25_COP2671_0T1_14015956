using UnityEngine;

public class Scorable : MonoBehaviour
{   
    public enum ScoreTypes
    {
        Cheese, Boost
    }

    private const string Cheese = "Cheese";
    private const string Booster = "Booster";
    public int scoreValue;
    public ScoreTypes scoreType;
    public virtual void Collect() 
    {
        Debug.LogWarning("No Custom Collect");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Scorable scorable))
        {
            scorable.Collect();
        }


        if (other.CompareTag(Cheese)) // Detect when the goblin gets cheese
        {
            Destroy(other.gameObject); // Destroy cheese
                                       // add Points
                                       // play sound
                                       // partice effects
        }

        if (other.CompareTag(Booster)) // Detect when the goblin hits a speed boost
        {
            // speed up player with impulse
            // play sounds
        }
    }
}

