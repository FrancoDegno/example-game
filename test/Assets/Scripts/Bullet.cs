using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField]
	Animator bulletAnimator;
	bool movement=true;


	public float BulletDmg { get;set;}
	public float ang { get;set;}




	void AngShot(float speed)
	{
		float trueAngle = ang * Mathf.PI / 180;
		this.transform.eulerAngles = new Vector3 (0, 0, ang);
		this.transform.position+= new Vector3(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime);
		//print (" cos "+Mathf.Cos(trueAngle)*speed*Time.deltaTime);
		//print (" sin" +Mathf.Sin(trueAngle)*speed*Time.deltaTime);
		//this.transform.Translate(new Vector2(Mathf.Cos(trueAngle)*speed*Time.deltaTime,Mathf.Sin(trueAngle)*speed*Time.deltaTime));

	}

	public virtual void bulletMov()
	{
		AngShot (12);
		}


    void Update()
    {
		bulletMov ();
		
    }



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == 8) {
			bulletAnimator.SetBool ("Collision", true);
			Destroy (this.gameObject, 0.5f);
			movement = false;
			print (BulletDmg);
			Destroy (this.GetComponent<Collider2D> ());
			other.gameObject.GetComponent<GreenShip> ().reciveDamage (BulletDmg);
		}

		if (other.gameObject.layer == 10)
			Destroy (this.gameObject);

	}

}
