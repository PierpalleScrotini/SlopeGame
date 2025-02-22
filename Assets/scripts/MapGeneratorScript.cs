using Unity.VisualScripting;
using UnityEngine;

public class MapGeneratorScript : MonoBehaviour
{
    public GameObject player;
    public GameObject[] mapParts;
    public GameObject trigger;
    public GameObject lastPart;
    public GameObject lastTrigger;
    GameObject selPart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++) 
        {
            createNewPart();
        }
    }

    public void createNewPart() 
    {
        selPart = mapParts[Random.Range(0, mapParts.Length)];

        Vector3 newPosition = new Vector3(lastPart.transform.position.x + Random.Range(-8, 8), lastPart.transform.position.y -20, lastPart.transform.position.z + 50);

        GameObject newPart = Instantiate(selPart, newPosition, Quaternion.Euler(0, 0, 0));
        GameObject newTrigger = Instantiate(trigger, newPosition + new Vector3(0,0,30), Quaternion.Euler(0,0,0));

        newTrigger.GetComponent<NewPartTriggerScript>().attachedPart = newPart;

        lastPart = newPart;
        lastTrigger = newTrigger;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
