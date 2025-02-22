using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 2f;

    public ScoreManager scoreManager;
    float minZSpeed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.x > speed) 
        {
            rb.linearVelocity += new Vector3(speed - rb.linearVelocity.x, 0, 0);
        }
        if (rb.linearVelocity.x < -speed)
        {
            rb.linearVelocity += new Vector3(-speed - rb.linearVelocity.x, 0, 0);
        }

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            if (rb.linearVelocity.x < 0.1f)
            {
                rb.linearVelocity += new Vector3(0.01f, 0, 0);
            }
            else if (rb.linearVelocity.x > 0.1f) 
            {
                rb.linearVelocity -= new Vector3(0.01f, 0, 0);
            }
        }

        rb.linearVelocity += new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, 0);

        if (scoreManager.score > 10000)
        {
            minZSpeed = scoreManager.score * 0.0005f;
        }

        if (Physics.Raycast(this.transform.position, new Vector3(0, -1, 0), 1)) 
        {
            if (rb.linearVelocity.z < minZSpeed)
            {
                rb.linearVelocity += new Vector3(0, 0, minZSpeed - rb.linearVelocity.z);
            }
        }
    }
}
