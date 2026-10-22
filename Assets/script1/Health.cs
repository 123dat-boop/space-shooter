using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public System.Action onDead;
    public int healthPoint;
    public System.Action onHealthChanged;
    
    private void Awake()
    {
        healthPoint = defaultHealthPoint;
    }
    
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        onHealthChanged?.Invoke();
        Debug.Log(gameObject.name + "HP con lai: " + healthPoint);
        if (healthPoint <= 0) Die();
    }
    
    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        onDead?.Invoke();
    }
    // Start is called before the first frame update
    private void Start()
    {
        healthPoint = defaultHealthPoint;
        onHealthChanged?.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
