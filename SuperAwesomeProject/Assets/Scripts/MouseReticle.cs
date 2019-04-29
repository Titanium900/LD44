using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseReticle : MonoBehaviour {
    // Use this for initialization
    float x;
    float y;
	void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        transform.position = new Vector3(x,y, -.3f)/50;
        transform.Translate(new Vector3(-9.3f+ GameObject.FindGameObjectWithTag("player").transform.position.x, -5.6f + GameObject.FindGameObjectWithTag("player").transform.position.y));
    }
}