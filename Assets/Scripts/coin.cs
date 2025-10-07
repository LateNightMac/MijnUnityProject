using UnityEngine;

public class coin : MonoBehaviour
{
    
    public static int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider : " + other.tag);

        if (other.CompareTag("player"))
        {
            score++; 
            Debug.Log("score: " + score); 

            Destroy(gameObject);
        }
    }
}
