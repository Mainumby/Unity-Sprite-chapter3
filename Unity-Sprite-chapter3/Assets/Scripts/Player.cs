using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
    public float speed = 200;
    public float maxSpeed = 5;
    int moving = 0;


    float mouseX = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            mouseX = 90 * ((Input.mousePosition.x - Screen.width/ 2)/ (Screen.width/2));    
        }
        else
	        {
                    mouseX =0;  

	        }
        if (Input.GetKey("right") || mouseX > 0)
        {
            moving = 1;
        }
        else
            if (Input.GetKey("left") || mouseX < 0)
            {
                moving = -1;       
            }
            else
            {
                moving = 0;
            }

        if (moving !=0 )
        {
            var velocityX = System.Math.Abs(rigidbody2D.velocity.x);

            if (velocityX < .5)
            {
                rigidbody2D.AddForce(new Vector2(moving, 0) * speed);

                if (this.transform.localScale.x != moving)
                {
                    this.transform.localScale = new Vector3(moving, 1, 1);
                }


            }

            if (velocityX > maxSpeed)
            {
                rigidbody2D.velocity = new Vector2(maxSpeed * moving, 0);
            }
        }

        
	}
}
