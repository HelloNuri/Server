﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDerector : MonoBehaviour {

    GameObject hpGage;
    
	// Use this for initialization
	void Start () {
        this.hpGage = GameObject.Find("hpGage");
	}
    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
