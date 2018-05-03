using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowGenerator : MonoBehaviour {
    public GameObject arrowPrefab;//프리펩 변수 선언
    public float span = 1.0f;
    float delta = 0;//Time.delta이 누적
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;//as로 매개변수 프리펩을 인스턴스로 반환(복제) as로 형변환
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            span -= 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            span += 0.1f;
        }
	}
}
