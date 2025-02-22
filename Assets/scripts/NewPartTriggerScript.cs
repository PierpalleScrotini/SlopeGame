using Mono.Cecil.Cil;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewPartTriggerScript : MonoBehaviour
{
    public MapGeneratorScript generator;
    public GameObject attachedPart;
    public GameObject triggerMesh;
    public bool boost = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        triggerMesh.SetActive(false);

        if (Random.Range(0,10) == 0)
        {
            triggerMesh.SetActive(true);
            boost = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "PlayerBall")
        {
            generator.createNewPart();

            if (boost)
            {
                other.GetComponent<Rigidbody>().linearVelocity += new Vector3(0, 0, 10);
            }

            Destroy(attachedPart);
            Destroy(this.gameObject);
        }
    }

}
