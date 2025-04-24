using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreUI;

    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
    }

    public int IncreaseScore(int increaseNumber)
    {
        score += increaseNumber;
        return score;
    }
}
