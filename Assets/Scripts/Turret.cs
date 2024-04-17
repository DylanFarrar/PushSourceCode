using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float projectileSpeed;
    [SerializeField] private Projectile projectilePrefab;
    public float fireRate;
    public float timeSinceLastShot;
    public float fireRateInterval;
    public float RANDOMNESS;
    private float lastShotTime;
    private float currentTime;
    public float nextShot;
    
    void Start()
    {
        timeSinceLastShot = 0;
        lastShotTime = 0;
        currentTime = 0;

        UnityEngine.Random.InitState((int)(DateTime.Now.Ticks & 0xFFFFFFFF));
        nextShot = 0.4f;
    }

    private void Update() {

        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        currentTime += Time.deltaTime;

        timeSinceLastShot = currentTime - lastShotTime;

        if (nextShot < timeSinceLastShot)
        {
                var position = transform.position + transform.forward;
                Quaternion rotation = transform.rotation;
                var projectile = Instantiate(projectilePrefab, position, rotation);
                projectile.Fire(projectileSpeed, transform.right);
                lastShotTime = currentTime;
                newTime();
        }
    } 

    void newTime(){
        fireRateInterval = UnityEngine.Random.Range(fireRate - RANDOMNESS, fireRate + RANDOMNESS);
        nextShot = 1 / (fireRateInterval / 60);
    }
}
