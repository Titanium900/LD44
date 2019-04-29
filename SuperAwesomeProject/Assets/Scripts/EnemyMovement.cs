using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("player");

    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindGameObjectWithTag("player");
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 2f * Time.deltaTime);
        if (Mathf.Sign(transform.position.x - player.transform.position.x) == 1)
        {
            transform.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            transform.GetComponent<SpriteRenderer>().flipX = false;
        }
         
    }
}
