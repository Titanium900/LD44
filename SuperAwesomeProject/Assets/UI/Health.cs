using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public int TimerAuth;
    public Text text;
    public static int health;
    void Start()
    {
        TimerAuth = 0;
        health = 0;
        text.text = "Health: " + health;
    }

    void Update()
    {
        health = PlayerHealth.health;
        if (TimerAuth == 0)
        {
            text.text = "Health: " + health;
        }

    }
}
