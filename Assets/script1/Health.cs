using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;

    private void Awake()
    {
        healthPoint = defaultHealthPoint;
    }
    private void Start() => healthPoint = defaultHealthPoint;
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        Debug.Log(gameObject.name + "HP con lai: " + healthPoint);
        if (healthPoint <= 0) Die();
    }
    
    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
