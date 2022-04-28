using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public GameObject player;
    public PlayerHandler playerHandler;
    public int health;
    public bool downBash;
    public bool laserTurt;
    public bool squishShoot;

    //enemy damage prefabs
    public GameObject squishShootPrefab;
    public GameObject bashPrefab;
    public GameObject laserPrefab;

    public Transform spawn;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && playerHandler.meleeActive)
        {
            //gameObject.SetActive(false);
            Damage(playerHandler.meleeDamage);

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
}