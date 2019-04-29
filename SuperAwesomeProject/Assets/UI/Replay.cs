using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replay : MonoBehaviour {
    public Button replay;
    void Start()
    {
        Button btn = replay.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick1);
    }

    void TaskOnClick1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
}