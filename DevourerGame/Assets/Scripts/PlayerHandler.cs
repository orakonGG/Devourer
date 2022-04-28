using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public bool meleeActive;
    public int meleeDamage = 25;
    public int health = 100;

    BoxCollider2D triggerBox;

    private float coolDownTime;
    //private bool isCoolDown;

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
            Debug.Log("V pressed.");
            Melee();

        }
    }

    // sets melee to active
    void Melee()
    {
        meleeActive = true;
        Debug.Log("If you're reading this, WTF.");
        CoolDown(2f);
        meleeActive = false;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && meleeActive)
        {
            other.gameObject.SetActive(false);
            Damage(other, meleeDamage);
        }

    }

    void Damage(Collider other, int ammount)
    {
        // gameObject.health = gameObject.health - ammount;
        // if (gameObject.health <= 0)
        // other.gameObject.setActive(false); 
    }

    IEnumerator CoolDown(float number)
    {
        // Start cooldown
        //isCoolDown = true;
        // Wait for time you want
        yield return new WaitForSeconds(coolDownTime);
        // Stop cooldown
        //isCoolDown = false;

    }

}