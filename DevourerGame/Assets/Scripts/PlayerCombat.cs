using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private bool meleeActive = false;
    public BoxCollider2D meleeTrigger;
    public float damage;
    
    // Start is called before the first frame update
    void Start()
    {
        // meleeTrigger = GetComponent<BoxCollider2D>;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v") && !meleeActive)
        {
            melee();
        }
    }

    void melee()
    {
        // if (meleeTrigger.IsTouching())
        // {
             // call damage script
        // }

        // wait time
        // deactivate melee

    }
}
