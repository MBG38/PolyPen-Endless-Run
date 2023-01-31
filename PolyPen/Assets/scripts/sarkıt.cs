using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarkıt : MonoBehaviour
{


    Rigidbody2D rb;
    Animator anim;
    void Start()
    {
        anim= GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -10);
        Destroy(this.gameObject, 3f);
        StartCoroutine(timer());
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        if(collision.collider.tag == "Player")
        {
            player_death.ölüm();
            //collision.gameObject.SetActive(false);
        }
    }
    IEnumerator  timer()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }

}
