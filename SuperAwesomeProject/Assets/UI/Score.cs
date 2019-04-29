using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int TimerAuth;
    public Text text;
    public static int score;
    void Start()
    {
        TimerAuth = 0;
        score = 0;
        text.text = "Robots Defeated: " + score;
    }

    void Update()
    {
        if (TimerAuth == 0)
        {
            text.text = "Robots Defeated: " + score;
        }

    }
}

