using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMov : MonoBehaviour {



    [SerializeField]
    float velX=0;
    [SerializeField]
    float velY = 0;
	[SerializeField]
	Animator myAnimator;
	[SerializeField]
	Animator propAnimator;

    float axisX, axisY;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        mov();       
	}


    void mov()
    {
		axisX = Input.GetAxis("Horizontal");
		axisY = Input.GetAxis("Vertical");
      
		       


		if (axisX == 0) {
			propAnimator.SetBool ("prop", true);
			propAnimator.SetBool ("Boost", false);
		}
		else
		if (axisX < 0) {
			propAnimator.SetBool ("prop",false);
			propAnimator.SetBool ("Boost", false);
		}
		else {
			propAnimator.SetBool ("prop", false);
			if (axisX > 0)
				propAnimator.SetBool ("Boost", true);
		}



		if (axisY == 0) {
			myAnimator.SetInteger ("State", 0);
		}

		if (axisX<0)
        {
            this.transform.position -= new Vector3(Time.deltaTime * velX, 0);

        }

		if (axisX>0)
        {
            this.transform.position += new Vector3(Time.deltaTime * velX, 0);

        }

		if (axisY>0)
        {
            this.transform.position += new Vector3(0, Time.deltaTime*velY);
			myAnimator.SetInteger ("State", 1);
        }

        if (axisY<0)
        {
            this.transform.position -= new Vector3(0, Time.deltaTime * velY);
			myAnimator.SetInteger ("State", -1);
        }


    }


}
