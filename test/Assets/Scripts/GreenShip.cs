﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShip : EnemyShip {


    public override void MovShip(float speed)
    {
        this.transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MovShip(speed);
	}
}
