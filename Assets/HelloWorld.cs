using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
    public List<string> displayText;
    public float speed = 2f;
	void Start () {
        displayText.Add("Hello");
        displayText.Add("World");
        
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(displayText[0]+ " "+ displayText[1]);
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
	}
}
