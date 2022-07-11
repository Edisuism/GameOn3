using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        UpdateText();
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void UpdateText()
    {
        scoreText.text = "Score: " + (int)score;
    }
}
