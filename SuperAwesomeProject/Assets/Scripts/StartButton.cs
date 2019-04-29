using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameObject back;
    // Use this for initialization
    void Start()
    {
        Button btn = back.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick1);
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("Story");
    }
}
