using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler2 : MonoBehaviour
{
    public bool meleeActive;
    public int meleeDamage = 25;
    private int health = 8;

    BoxCollider2D triggerBox;

    private float coolDownTime;
    private bool isCoolDown;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        triggerBox = GetComponent<BoxCollider2D>();
        meleeActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Debug.Log("V pressed.");
            Melee();
        }
    }

    // sets melee to active
    void Melee()
    {
        if (meleeActive)
        {
            Debug.Log("You can't attack while you're already attacking!");
        }
        else
        {
            meleeActive = true;
            animator.SetBool("isPunching", true);
            Debug.Log("melee active");
            StartCoroutine(CoolDown());
        }

    }



    void Damage(int ammount)
    {
        health = health - ammount;
        if (health <= 0)
        {
            //respawn
            Debug.Log("dead");
        }

    }

    IEnumerator CoolDown()
    {
        // Start cooldown
        isCoolDown = true;
        // Wait for time you want
        yield return new WaitForSeconds(0.5f);
        // Stop cooldown
        isCoolDown = false;
        meleeActive = false;
        animator.SetBool("isPunching", false);
        Debug.Log("melee false");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "projectile")
        {


            Destroy(other.gameObject);
            //the animation would still play to completion
            Damage(1);


        }
    }
}