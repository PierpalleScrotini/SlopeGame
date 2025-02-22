using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public float multiplier = 1f;

    public GameObject player;
    public Rigidbody playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        multiplier = playerRb.linearVelocity.z / 10;
        score += (int)(multiplier);
    }
}
