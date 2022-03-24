using System.Collections;
using UnityEngine;
public class Weapon : MonoBehaviour
{
    public int damageBounus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("yum!");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
