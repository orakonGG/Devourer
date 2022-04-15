using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public bool meleeActive;
    public int meleeDamage = 25;
    private int health = 100;

    BoxCollider2D triggerBox;

    private float coolDownTime;
    private bool isCoolDown;




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
            //Debug.Log("V pressed.");
            Melee();
           // StopCoroutine(CoolDown());
           // StartCoroutine(CoolDown());
            //Melee();

        }
    }

    // sets melee to active
    void Melee()
    {
        if (meleeActive)
        {
            meleeActive = false;

            Debug.Log("melee false");
        }
        else
        {
            meleeActive = true;

            Debug.Log("melee active");
        }

    }
    


    void Damage(GameObject hit, int ammount)
    {
        

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