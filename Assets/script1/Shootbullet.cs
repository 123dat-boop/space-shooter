using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootbullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    public Vector3 bulletOffset;
    private float lastBulletTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }
    private void UpdateFiring()
    {
        if(Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }
    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }
}
