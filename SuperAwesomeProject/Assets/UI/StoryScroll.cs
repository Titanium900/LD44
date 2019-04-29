using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StoryScroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Next", 22);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, .01f, .01f);
	}
    void Next()
    {
        SceneManager.LoadScene("MainGame");
    }
}
