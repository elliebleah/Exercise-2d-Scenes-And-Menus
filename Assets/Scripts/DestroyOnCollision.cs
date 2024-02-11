using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag;


    // Check for collisions
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided GameObject has the specified tag
        if (other.CompareTag(targetTag))
        {
            // Destroy this GameObject
            if (this.gameObject.GetComponent<Explode>() != null)
            {
                this.gameObject.GetComponent<Explode>().explodeOnImpact();
            }
            if (this.tag == "Player")
            {
                PlayerPrefs.SetInt("HighScore", Singleton.singleton.notifyGetScore());
                SceneManager.LoadScene("HighScore");
            }

            
            Destroy(gameObject);

            

            if (targetTag == "bullet" || targetTag == "Bullet")
            {
                Singleton.singleton.notifyScoreChange(10);
            }

            
        }

        
    }

    // Check if the GameObject doesn't have a Collider2D attached
    void OnValidate()
    {
        if (GetComponent<Collider2D>() == null)
        {
            Debug.LogWarning("GarbageCollector: No Collider2D attached to GameObject.");
        }
    }
}
