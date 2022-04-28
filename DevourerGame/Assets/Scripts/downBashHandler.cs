using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downBashHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //audio and sprite based off tree game

        //gameObject.GetComponent<AudioSource>().Play();
        //GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
        // StartCoroutine(DestroyVFX(boomFX));
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}