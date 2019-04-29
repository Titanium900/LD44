using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {
    public GameObject tile;
    public GameObject reticle;
    public GameObject ball;
    public GameObject slimeRing;
    bool coolDown;
    bool moveAni;
    Vector3 currentPos;
    Vector3 lastPos;
	// Use this for initialization
	void Start () {
        moveAni = true;
        coolDown = false;
        Instantiate(reticle, transform.position, transform.rotation);
    }

    
    
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(.1f,0,0));
            
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-.1f, 0, 0));
            
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, .1f, 0));
            //Up();
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -.1f, 0));
            //Up();
        }
        if (Input.GetKeyDown("space") && coolDown == false)
        {
            Instantiate(slimeRing, transform.transform).transform.SetParent(null);
            coolDown = true;
            Invoke("Refresh", 2);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ball, new Vector3(transform.position.x,transform.position.y,-.03f), new Quaternion());
        }
        currentPos = transform.position;
        if(currentPos.x - lastPos.x > .9)
        {
            for (int y = -12; y < 12; y++)
            {
                Instantiate(tile, new Vector3(Mathf.Round(transform.position.x + 10), Mathf.Round(transform.position.y + y), 0), new Quaternion()).transform.Rotate(-90, 0, 0);
            }
        }
        if (Mathf.Abs(currentPos.x - lastPos.x) > .9)
        {
            for (int y = -12; y < 12; y++)
            {
                Instantiate(tile, new Vector3(Mathf.Round(transform.position.x - 10), Mathf.Round(transform.position.y + y), 0), new Quaternion()).transform.Rotate(-90, 0, 0);
            }
        }
        if (currentPos.y - lastPos.y > .9)
        {
            for (int x = -12; x < 12; x++)
            {
                Instantiate(tile, new Vector3((Mathf.Round(transform.position.x)) + x, (Mathf.Round(transform.position.y + 10)), 0), new Quaternion()).transform.Rotate(-90, 0, 0);
            }
        }
        if (Mathf.Abs(currentPos.y - lastPos.y) > .9)
        {
            for (int x = -12; x < 12; x++)
            {
                Instantiate(tile, new Vector3((Mathf.Round(transform.position.x)) + x, (Mathf.Round(transform.position.y - 10)), 0), new Quaternion()).transform.Rotate(-90, 0, 0);
            }
        }
        if(currentPos.x - lastPos.x > .9|| Mathf.Abs(currentPos.x - lastPos.x) > .9|| currentPos.y - lastPos.y > .9|| Mathf.Abs(currentPos.y - lastPos.y) > .9)
        {
            lastPos = currentPos;
            if (moveAni == true)
            {
                transform.GetComponent<SpriteRenderer>().flipX = true;
                moveAni = false;
            }
            else
            {
                transform.GetComponent<SpriteRenderer>().flipX = false;
                moveAni = true;
            }
        }
    }
    void Refresh()
    {
        coolDown = false;
    }
}
