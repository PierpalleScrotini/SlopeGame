using JetBrains.Annotations;
using System;
using UnityEngine;

public class ColorChangingScript : MonoBehaviour
{
    public float colorMult = 0.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Material newMat = new Material(this.gameObject.GetComponent<MeshRenderer>().sharedMaterial);
        float curPos = this.gameObject.transform.position.z;
        float newColor;
        const int DIST = 2000;
        

        if ((int)(curPos / DIST) % 2 == 0)
        {
            newColor = (curPos - (DIST * (int)(curPos / DIST)));
        }
        else
        {
            newColor = DIST - (curPos - (DIST * (int)(curPos / DIST)));
        }
        newColor /= DIST;

        newMat.SetColor("_BaseColor", new Color(newColor * colorMult, 0, colorMult));

        this.gameObject.GetComponent<Renderer>().material = newMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
