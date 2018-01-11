using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour {
    [SerializeField]
    float velX=0;
    [SerializeField]
    float velY = 0;


    float axisX, axisY;
    Rigidbody2D myRig;
	// Use this for initialization
	void Start () {
        myRig = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        mov();       
	}


    void mov()
    {
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");
        myRig.velocity = new Vector3(axisX * velX, axisY * velY);

    }


}
