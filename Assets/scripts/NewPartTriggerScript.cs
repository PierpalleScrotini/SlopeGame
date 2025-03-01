using Mono.Cecil.Cil;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewPartTriggerScript : MonoBehaviour
{
    public MapGeneratorScript generator;
    public GameObject attachedPart;
    public GameObject triggerMesh;

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
            generator.createNewPart();

            Destroy(attachedPart);
            Destroy(this.gameObject);
        }
    }

}
