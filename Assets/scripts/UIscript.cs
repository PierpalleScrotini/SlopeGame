using TMPro;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    public ScoreManager managerScript;

    public TMP_Text scoreText;
    public TMP_Text speedText;

    public GameObject analogSpeedDial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(managerScript.score.ToString());
        speedText.SetText(((int)managerScript.playerRb.linearVelocity.z).ToString());
        analogSpeedDial.transform.rotation = Quaternion.Euler(0,0, managerScript.playerRb.linearVelocity.z * -3);
    }
}
