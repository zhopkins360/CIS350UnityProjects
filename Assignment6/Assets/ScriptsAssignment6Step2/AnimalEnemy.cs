/*
*Zackary Hopkins
*Assignment 6
*an abstract class for the animal eneimes that will be spawned
*uses the interface IDamageable
*holds vars for speed, health, and bounds for the enimes. Also implements the destroyIfOutofBounds function
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalEnemy : MonoBehaviour, IDamageable
{
    [SerializeField] protected float speed = 35;
    [SerializeField] protected int health = 1;
    [SerializeField] protected float topBound = 25;
    [SerializeField] protected float bottomBound = -5;
    public abstract void TakeDamage(int amount);
    protected void destroyIfOutofBounds()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            //grad the health system script
            HealthSystem.Instance.TakeDamage(1);
            Destroy(gameObject);
        }
    }
    protected abstract void moverForward(float speed);
    
}
