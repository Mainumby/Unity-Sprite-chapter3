using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// Use this for initialization
    public int maxHealth = 10;
    public int health = 10;

    //after bloodpuddle
    public GameObject deathInstance = null;
    public Vector2 deathInstanceOffset = new Vector2(0, 0);
	void Start () {
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(int value)
    {
        Debug.Log("Take Damage " + value);
        health -= value;
        if (health <= 0)
        {
            OnKill();
        }
    }

    void OnKill()
    {

        if (deathInstance)
        {
            var pos = gameObject.transform.position;
            GameObject clone = Instantiate(deathInstance, new Vector3(pos.x + deathInstanceOffset.x, pos.y + deathInstanceOffset.y, pos.z)
                , Quaternion.identity) as GameObject;
        }
        Destroy(gameObject);
    }
}
