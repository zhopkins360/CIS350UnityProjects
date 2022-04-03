/*
*Zackary Hopkins
*Assignment 6
*one of the eneimes that inherits from AnimalEnemy. implements the take damage and moverForward
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogEnemy : AnimalEnemy
{
    public override void TakeDamage(int amount)
    {
        GameManager.Instance.score++;
        Destroy(gameObject);
    }

    protected override void moverForward(float speed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        destroyIfOutofBounds();
        moverForward(speed);
    }
}
