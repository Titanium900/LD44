using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTexturing : MonoBehaviour {
    public Material grass1;
    public Material grass2;
    public Material grass3;
    public Material tile1;
    public Material tile2;
    public Material tile3;
    int num;
	// Use this for initialization
	void Start () {
        num = Random.Range(1, 4);
        if(num == 1)
        {
            transform.GetComponent<Renderer>().material = tile1;
        }
        if (num == 2)
        {
            transform.GetComponent<Renderer>().material = tile2;
        }
        if (num == 3)
        {
            transform.GetComponent<Renderer>().material = tile3;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("hitbox"))
        {
            num = Random.Range(0, 4);
            if (num == 1)
            {
                transform.GetComponent<Renderer>().material = grass1;
            }
            if (num == 2)
            {
                transform.GetComponent<Renderer>().material = grass2;
            }
            if (num == 3)
            {
                transform.GetComponent<Renderer>().material = grass3;
            }
        }
    }
}
