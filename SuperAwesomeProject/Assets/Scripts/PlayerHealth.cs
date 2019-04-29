using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public static int health;
    public GameObject enemy;
    public GameObject deadOverlay;
	// Use this for initialization
	void Start () {
        health = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            GameObject.FindGameObjectWithTag("camera").transform.SetParent(null);
            Instantiate(enemy, transform.position - new Vector3(0, -10, 0), new Quaternion()).tag = "player";
            Instantiate(deadOverlay);
            Cursor.visible = true;
            Destroy(GameObject.FindGameObjectWithTag("hitbox"));
            Destroy(gameObject.transform.parent.gameObject);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            health--;
        }
    }
}
