using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float delay;
    bool shoot;
    float lateTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space) && shoot)
        {
            shoot = false;
            lateTime = Time.time;

            TripleShot();

        }

        if(Time.time>lateTime+delay)
        {
            shoot = true;
            lateTime = Time.time;

        }

    }


    void TripleShot()
    {
        GameObject auxBullet = (GameObject)Instantiate(Bullet, this.transform.position, this.transform.rotation);
        auxBullet.GetComponent<Bullet>().TypeBullet = 1;

        auxBullet = (GameObject)Instantiate(Bullet, this.transform.position, this.transform.rotation);
        auxBullet.GetComponent<Bullet>().TypeBullet = 0;

        auxBullet = (GameObject)Instantiate(Bullet, this.transform.position, this.transform.rotation);
        auxBullet.GetComponent<Bullet>().TypeBullet = 2;
    }


}
