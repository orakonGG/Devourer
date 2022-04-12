using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public bool meleeActive;
    public int meleeDamage = 25;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        meleeActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Melee();
        }
    }

    void Melee()
    {
        meleeActive = true;
        CoolDown(1.1f);
        meleeActive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy") && meleeActive)
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
        yield return new WaitForSeconds(number);

    }

}