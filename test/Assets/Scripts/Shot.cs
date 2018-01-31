using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Shot : MonoBehaviour {
    [SerializeField]
    GameObject Bullet;
	[SerializeField]
	Transform CannonPos;
	[SerializeField]
	float dmg;


	[SerializeField]
	protected Animator myAnimator;

    [SerializeField]
	protected float delay;




	public abstract void Shooting ();


	protected void HommingShot()
	{
		
	
	}

	protected void SingleShot(float ang)
	{
		GameObject auxBullet = (GameObject)Instantiate(Bullet, CannonPos.position, this.transform.rotation);
		auxBullet.GetComponent<Bullet> ().BulletDmg = dmg;
		auxBullet.GetComponent<Bullet> ().ang = ang;
	}

	protected void TripleShot(float ang1,float ang2,float ang3)
    {
		float[] angles = new float[3]{ ang1, ang2, ang3 };
		GameObject auxBullet;
		for (int i = 0; i < 3; i++) {
			auxBullet=(GameObject)Instantiate(Bullet, CannonPos.position, this.transform.rotation);
			Bullet AUX = auxBullet.GetComponent<Bullet> ();
			AUX.BulletDmg = dmg;
			AUX.ang = angles [i];
		}

	
    }


}
