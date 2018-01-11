using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    public int TypeBullet { get; set; }

  
    void movX(float speed)
    {
        this.transform.Translate(Vector2.right * speed);
    }

    void mov45S(float speed)
    {
        this.transform.Translate(new Vector2(1 * speed, 1 * speed));
    }

    void mov45I(float speed)
    {
        this.transform.Translate(new Vector2(1 * speed, -1 * speed));
    }



    void Update()
    {
        switch(TypeBullet)
        {
            case 0:
                movX(0.1f);
                break;
            case 1:
                mov45S(0.1f);
                break;
            case 2:
                mov45I(0.1f);
                break;

        }
    }

}
