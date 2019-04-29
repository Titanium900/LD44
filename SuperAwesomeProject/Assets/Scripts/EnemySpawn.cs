using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject enemy;
    public GameObject player;
    bool above;
    int randY;
    int randX;
	// Use this for initialization
	void Start () {
        above = true;
        InvokeRepeating("Spawn", 2f, 2f);
	}
	
	// Update is called once per frame
	void Update () {

    }
    void Spawn()
    {
        if(above == true)
        {
            Instantiate(enemy, new Vector3(10 + player.transform.position.x, Random.Range(-5, 6) + player.transform.position.y, -.01f), new Quaternion());
            Instantiate(enemy, new Vector3(Random.Range(-5, 6) + player.transform.position.x, 10 + player.transform.position.y, -.01f), new Quaternion());
            above = false;
        }
        else if(above == false)
        {
            Instantiate(enemy, new Vector3(-10 + player.transform.position.x, Random.Range(-5, 6) + player.transform.position.y, -.01f), new Quaternion());
            Instantiate(enemy, new Vector3(Random.Range(-5, 6) + player.transform.position.x, -10 + player.transform.position.y, -.01f), new Quaternion());
            above = true;
        }
    }
}
