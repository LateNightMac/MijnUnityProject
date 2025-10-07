using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public float bewegingsKracht = 10.0f;
    public float springKracht = 300.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // WASD beweging met physics
        float horizontal = Input.GetAxis("Horizontal"); // A/D toetsen
        float vertical = Input.GetAxis("Vertical");     // W/S toetsen

        // Voeg krachten toe in X en Z richting
        Vector3 beweging = new Vector3(horizontal, 0, vertical);
        rb.AddForce(beweging * bewegingsKracht);

        // Spring met Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * springKracht);
        }

        // Toon huidige snelheid
       // Debug.Log("Snelheid: " + rb.linearVelocity.magnitude);
    }
}
