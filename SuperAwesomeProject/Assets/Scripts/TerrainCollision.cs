using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("tile"))
        {
            Destroy(transform);
        }
    }
}
