using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    public GameObject target;
    private Transform targetPos;
	// Use this for initialization
	void Start () {
        targetPos = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (targetPos)
        {
            transform.position = new Vector3(targetPos.position.x, targetPos.position.y, transform.position.z);
        }
	}
}
