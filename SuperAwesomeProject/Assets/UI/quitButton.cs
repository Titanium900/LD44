using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quitButton : MonoBehaviour {
	public Button quit;
    void Start()
    {
        Button btn = quit.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick1);
    }
    
    void TaskOnClick1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
}