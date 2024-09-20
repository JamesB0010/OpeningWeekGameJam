using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float health = 100;

    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            this.health = value;

            if(this.health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void DealDamage(float damage)
    {
        this.Health -= damage;

        Debug.Log("Health remaining " + this.health);
    }
}
