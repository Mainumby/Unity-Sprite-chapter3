using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
    public int attackValue = 1;
    public float attackDelay = 1f;
    public string targetTag;
    private bool canAttack;

	void Start () {
        if (attackValue <= 0)
        {
            canAttack = false;
        }
        else
        {
            StartCoroutine(OnAttack());
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay2D(Collision2D c)
    {
        
        if (c.gameObject.tag == targetTag)
        {
           
            if (canAttack)
            {
                Debug.Log("Game Object Tag =" + gameObject.tag + "Target Tag= " + targetTag);
                TestAttack(c.gameObject);
            }
        }
    }

    void TestAttack(GameObject target)
    {
        if (transform.localScale.x == 1)
        {
            if (target.transform.position.x > transform.position.x)
            {
                AttackTarget(target);   
            }
        }
       else
            {
                if (target.transform.position.x < transform.position.x)
                {
                   AttackTarget(target);   
                }

                
            }
            canAttack = false;
        
    }


    void AttackTarget(GameObject target)
    {
        var healthComponent = target.GetComponent<Health>();
        if (healthComponent)
        {
            healthComponent.TakeDamage(attackValue);
        }
    }


    IEnumerator OnAttack()
    {
        yield return new WaitForSeconds(attackDelay);
        canAttack = true;
        StartCoroutine(OnAttack());
    }
}
