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

        float ang = 10 * Mathf.PI / 180;
       
		this.transform.eulerAngles = new Vector3 (0, 0, 10);
        this.transform.Translate(new Vector2(Mathf.Cos( ang)* speed, Mathf.Sin(ang) * speed));
    }

    void mov45I(float speed)
    {
        float ang = 10 * Mathf.PI / 180;
		this.transform.eulerAngles = new Vector3 (0, 0, -10);
        this.transform.Translate(new Vector2(Mathf.Cos(ang) * speed, -1 * speed* Mathf.Sin(ang)));
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
