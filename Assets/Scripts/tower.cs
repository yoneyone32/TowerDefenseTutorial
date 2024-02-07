using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    public HPbar hpBar;
    public float maxHP = 100f;
    private float currentHP;

    private void Start()
    {
        currentHP = maxHP;
        hpBar.setHP(currentHP / maxHP);
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        hpBar.setHP(currentHP / maxHP);

        if(currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
