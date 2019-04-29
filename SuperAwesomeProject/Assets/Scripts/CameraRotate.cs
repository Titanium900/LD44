using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(0,.1f,0));
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 5);
    }
}
