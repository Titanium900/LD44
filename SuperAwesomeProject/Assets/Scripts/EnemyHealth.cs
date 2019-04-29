using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    float health;
    public GameObject slime;
	// Use this for initialization
	void Start () {
        health = 2;
    }
	
	// Update is called once per frame
	void Update () {
		if(health == 1)
        {
            Instantiate(slime, transform.transform).transform.SetParent(transform);
        }
        if(health <= 0)
        {
            Destroy(gameObject);
            Score.score += 1;
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            Destroy(other.gameObject);
            health--;
        }
        if (other.gameObject.tag == "slimering")
        {
            health = health - 2;
        }
    }
}
