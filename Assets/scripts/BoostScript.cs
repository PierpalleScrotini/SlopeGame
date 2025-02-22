using UnityEngine;

public class BoostScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerBall")
        {
            Rigidbody rigidbody = other.GetComponent<Rigidbody>();
            rigidbody.linearVelocity += new Vector3(0, -5, 10);
        }
    }
}
