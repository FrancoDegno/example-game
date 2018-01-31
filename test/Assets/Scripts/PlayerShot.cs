using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : Shot {

	bool shoot;
	float lateTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Shooting ();
	}

	public override void Shooting()
	{
		if (Input.GetKey (KeyCode.Space) && shoot) {
			shoot = false;
			lateTime = Time.time;

			myAnimator.SetBool ("charge", true);
			TripleShot (10, 0, -10);

		} else

			if(Input.GetKeyUp(KeyCode.Space))
				myAnimator.SetBool ("charge", false);

		if(Time.time>lateTime+delay)
		{
			shoot = true;
			lateTime = Time.time;

		}

	}


}
