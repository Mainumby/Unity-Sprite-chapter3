using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	// Use this for initialization
    public float speed = .3f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody2D.velocity = new Vector2(this.transform.localScale.x, 0) * speed;
	}
}
