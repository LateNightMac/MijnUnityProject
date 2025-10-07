using UnityEngine;

public class colortrigger : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        // Renderer ophalen om de kleur te kunnen veranderen
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Kies een willekeurige kleur bij botsing
        rend.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
}

