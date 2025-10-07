using UnityEngine;

public class PoortTrigger : MonoBehaviour
{
    public bool verwijderPoort = false; // in inspector aanvinken

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Iets is door het poortje gegaan: " + other.name);

        if (verwijderPoort)
        {
            Destroy(gameObject); // Verwijdert het poortje zelf
        }
    }
}
