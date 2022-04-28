using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHandler : MonoBehaviour
{
    public GameObject player;
    public PlayerHandler2 playerHandler;
    public int health;
    public bool downBash;
    public bool laserTurt;
    public bool squishShoot;

    //enemy damage prefabs
    public GameObject squishShootPrefab;
    public GameObject bashPrefab;
    public GameObject laserPrefab;

    public Transform spawn;
    public bool attackTrue;

    public bool isCoolDown = false;


    // Start is called before the first frame update
    void Start()
    {
        attackTrue = true;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && playerHandler.meleeActive)
        {
            gameObject.SetActive(false);
            Damage(playerHandler.meleeDamage);

        }


    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && playerHandler.meleeActive)
        {
            gameObject.SetActive(false);
            Damage(playerHandler.meleeDamage);

        }
    }

        public void Attack()
    {
        
        if (!isCoolDown && attackTrue)
        {
            attackTrue = false;
            if (downBash)
            {
                DownBash();
            }
            if (squishShoot)
            {
                SquishShoot();
            }
            if (laserTurt)
            {
                Laser();
            }
            attackTrue = true;
        }
    }
    

    public void Damage(int ammount)
    {
        health = health - ammount;
        if (health <= 0)
        {
            gameObject.SetActive(false);

        }
    }

    public void DownBash()
    {
        if (downBash)
        {
            Instantiate(bashPrefab, spawn.position, Quaternion.identity);

        }
    }
    public void SquishShoot()
    {
        if (squishShoot)
        {
            Instantiate(squishShootPrefab, spawn.position, Quaternion.identity);
        }
    }
    public void Laser()
    {
        if (laserTurt)
        {
            Instantiate(laserPrefab, spawn.position, Quaternion.identity);
        }
    }

    IEnumerator CoolDown()
    {
        // Start cooldown
        isCoolDown = true;
        // Wait for time you want
        yield return new WaitForSeconds(5f);
        // Stop cooldown
        isCoolDown = false;
    }
}