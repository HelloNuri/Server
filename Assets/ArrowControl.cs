using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControl : MonoBehaviour {
    GameObject player;
    float r1 = 0.5f;//화살 콜리젼
    float r2 = 1.0f;// 고양이 콜리젼
	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;

        if (dir.magnitude < r1 + r2)
        {
            Destroy(gameObject);
            GameObject director = GameObject.Find("GameDerector");
            director.GetComponent<GameDerector>().DecreaseHp();
        }


	}
}
