using TMPro;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    public ScoreManager managerScript;

    public TMP_Text scoreText;
    public TMP_Text speedText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(((int)managerScript.score).ToString());
        speedText.SetText(((int)(managerScript.playerRb.linearVelocity.magnitude * 3.6)).ToString());

        if (managerScript.playerRb.linearVelocity.z > 99)
        {
            speedText.color = Color.red;
        }
        else
        {
            speedText.color = Color.white;
        }

    }
}
