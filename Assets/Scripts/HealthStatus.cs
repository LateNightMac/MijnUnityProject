using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    public int health = 100;  // Startwaarde van health
    public int changeAmount = 10; // Hoeveel health toeneemt of afneemt

    void Update()
    {
        // Health verlagen met toets H
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= changeAmount;
            CheckHealth();
        }

        // Health verhogen met toets J
        if (Input.GetKeyDown(KeyCode.J))
        {
            health += changeAmount;
            CheckHealth();
        }
    }

    // Functie om de health status te controleren en berichten te tonen
    void CheckHealth()
    {
        // Zorg dat health binnen 0 - 100 blijft
        health = Mathf.Clamp(health, 0, 100);

        if (health > 80)
        {
            Debug.Log("Excellent health!");
        }
        else if (health > 50)
        {
            Debug.Log("Good health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low health!");
        }
        else
        {
            Debug.Log("Critical: Very low health!");
        }

        Debug.Log("Current Health: " + health);
    }
}
