using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class EnemyShip : MonoBehaviour {


    [SerializeField]
    float Hp;
    [SerializeField]
    protected float speed;

    public abstract void MovShip(float speed);

    public void reciveDamage(float dmg)
    {
        Hp -= dmg;
        if (Hp <= 0) death();

    }

    void death()
    {
        Destroy(this);
    }




}
