using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Drawers;
using UnityEngine.Events;
using System;
using Sirenix.OdinInspector.Editor;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectilecomponent : SerializedMonoBehaviour
{
    Rigidbody2D rb;

    public float projectileSpeed = 2f;
    public UnityEventOnTriggerEnter2D TriggerEnter2D;
    public UnityEventOnCollisionEnter2D CollisionEnter2D;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void LaunchProjectile( )
    {
        
        SetVelocity(transform.forward * projectileSpeed);
    }
    public void LaunchProjectile(Vector2 LaunchDirection)
    {

        SetVelocity(LaunchDirection * projectileSpeed);
    }
    public void LaunchProjectile(float LaunchSpeed=2f)
    {
        projectileSpeed = LaunchSpeed;
        SetVelocity(transform.forward * projectileSpeed);
    }
    public void SetVelocity(Vector2 velocity)
    {
        rb.velocity = velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerEnter2D?.Invoke(collision);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionEnter2D?.Invoke(collision);
    }

}
