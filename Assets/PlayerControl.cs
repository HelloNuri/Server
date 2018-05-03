using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.5f, 0, 0);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.5f,0,0);
        }
	}
    public void LButtonDown()
    {
        transform.Translate(-2, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(2, 0, 0);
    }
}
