using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            TriggerDealthVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDealthVFX()
    {
        if(!deathVFX) { return; }

        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject, 1f);
    }
}
