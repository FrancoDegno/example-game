using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class EnemyShip : MonoBehaviour {


    [SerializeField]
    float Hp;
    [SerializeField]
    protected float speed;
	[SerializeField]
	protected Animator EnemyAnim;
	[SerializeField]
	GameObject explotion;


    public abstract void MovShip(float speed);

    public void reciveDamage(float dmg)
    {
        Hp -= dmg;
		if (Hp <= 0)
			death ();
		else
			reciveHit ();

    }

	void reciveHit()
	{

		EnemyAnim.SetBool ("Hit", true);
		StartCoroutine ("offAnim");
	}

	IEnumerator offAnim()
	{
		yield return new WaitForEndOfFrame ();
		EnemyAnim.SetBool ("Hit", false);
	
	}

    void death()
    {
		Destroy(this.gameObject);
		Instantiate (explotion, this.transform.position, this.transform.rotation);
    }




}
