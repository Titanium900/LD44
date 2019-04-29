using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBallMove : MonoBehaviour {
    Vector3 recticlePos;
    Vector3 lastPos;
	// Use this for initialization
	void Start () {
        recticlePos = GameObject.FindGameObjectWithTag("reticle").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, recticlePos , 20 * Time.deltaTime);
        if(lastPos - transform.position == new Vector3())
        {
            Destroy(gameObject);
        }
        lastPos = transform.position;
    }
}
