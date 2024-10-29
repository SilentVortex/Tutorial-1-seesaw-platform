using UnityEngine;
// This script was made by copilot.
public class PlayerDetector2D : MonoBehaviour
{

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Add logic to tilt the platform
            rb.AddTorque(10, ForceMode2D.Impulse);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Add logic to stop tilting the platform
            rb.AddTorque(-10, ForceMode2D.Impulse);
        }
    }
}
