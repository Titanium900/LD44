using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour {
    int size;
    public GameObject tile;
    public GameObject player;
	// Use this for initialization
	void Start () {
        size = 20;
        for (int x = -size; x < size; x++)
        {
            for (int y = -size; y < size; y++)
            {
                Instantiate(tile, new Vector3(0 + player.transform.position.x + x, 0 + player.transform.position.y + y, 0), new Quaternion(0, 0, 0, 0)).transform.Rotate(-90,0,0);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
