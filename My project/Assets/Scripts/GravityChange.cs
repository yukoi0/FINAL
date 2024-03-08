using UnityEngine;

public class RandomGravity : MonoBehaviour
{
    [SerializeField] private float minGravityScale = 0.5f;
    [SerializeField] private float maxGravityScale = 2f;
    [SerializeField] private float changeInterval = 2f; // Time interval between gravity changes

    private Rigidbody2D rb;
    private float nextChangeTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nextChangeTime = Time.time + changeInterval;
    }

    private void Update()
    {
        // Check if it's time to change gravity
        if (Time.time >= nextChangeTime)
        {
            // Generate a random gravity scale within the specified range
            float newGravityScale = Random.Range(minGravityScale, maxGravityScale);
            rb.gravityScale = newGravityScale;

            // Update the next change time
            nextChangeTime = Time.time + changeInterval;
        }
    }
}
