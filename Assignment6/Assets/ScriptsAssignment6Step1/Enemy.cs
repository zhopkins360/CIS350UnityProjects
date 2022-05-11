/*
*Zackary Hopkins
*Assignment 6
*an enemy abstract class to set a baseline for what eneimes should have
*have IDamageable Interface
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour , IDamageable
{
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;


    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();

        speed = 5f;
        health = 100;
    }

    protected abstract void Attack();
    public abstract void TakeDamage(int amount);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}