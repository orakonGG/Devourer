using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 3f;
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
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
