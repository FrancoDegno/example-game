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

    float axisX, axisY,savedVelX;
	// Use this for initialization
	int stop=1;
	
	// Update is called once per frame
	void Update () {
		print (Time.timeScale);
        mov();       
		if (stop == 0) {
			if (Time.timeScale <= 3) {
				Time.timeScale += Time.deltaTime * 0.1f;
			}
		} else 
		{
			if (Time.timeScale >= 3) {
				Time.timeScale -= Time.deltaTime*0.2f;
			
		}
		}
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
			this.transform.position += new Vector3(Time.deltaTime *stop* velX, 0);

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

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.layer == 12) {
			stop = 0;
			velY = velY / 2;

		}
	
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.layer == 12) {
			stop =1;
			velY = velY*2;

		}
		
	}


}
