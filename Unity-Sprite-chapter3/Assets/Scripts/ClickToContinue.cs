using UnityEngine;
using System.Collections;

public class ClickToContinue : MonoBehaviour {

	// Use this for initialization
    public string scene;
    private bool loadLock = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)&& !loadLock)
        {
            LoadScene();
        }
	}

    void LoadScene()
    {
        if (scene==null)
        {
            return;
            
        }
        loadLock = true;
        Application.LoadLevel(scene);
    }
}
