using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;
    private void Awake()
    {
        LivingEnemyCount++;
    }
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
        Debug.Log("Enemy died");
    }
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
