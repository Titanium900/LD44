using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeRingAttack : MonoBehaviour {
    float speed;
    int x;
	// Use this for initialization
	void Start () {
        speed = 20f;
        transform.localScale = new Vector3(1,1,1);

    }
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
        transform.position = GameObject.FindGameObjectWithTag("player").transform.position;
        transform.Rotate(new Vector3(0,0,5));
        if(transform.localScale.x >= 10)
        {
            Destroy(gameObject);
        }
        //transform.localScale = new Vector3()
    }
}
