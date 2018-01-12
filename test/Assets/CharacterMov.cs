using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

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
        /* axisX = CrossPlatformInputManager.GetAxis("Horizontal");
         axisY = CrossPlatformInputManager.GetAxis("Vertical");
         print(axisX);

         myRig.velocity = new Vector2(axisX * velX, axisY * velY);
         */


       

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position -= new Vector3(Time.deltaTime * velX, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(Time.deltaTime * velX, 0);

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, Time.deltaTime*velY);

        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position -= new Vector3(0, Time.deltaTime * velY);

        }


    }


}
