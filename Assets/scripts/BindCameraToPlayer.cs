using UnityEngine;

public class BindCameraToPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    Rigidbody playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y, player.transform.position.z + offset.z);

        this.GetComponent<Camera>().fieldOfView = 60 + (playerRb.linearVelocity.z / 2);
    }
}
