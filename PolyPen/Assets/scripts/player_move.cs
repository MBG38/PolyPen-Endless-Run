using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class player_move : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public float jumpHeight ;
    public float hýzdegis ;
    Animator anim;
    bool ky = true;
    public float timer=3f;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==("yer"))
        {
            ky = true;
        }
    }


    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime * 1;
        }
        else if (timer < 1)
        {
            timer += 2;
            hýzdegis += 0.6f;
        }

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * Time.deltaTime * hýzdegis;
        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump")/*Mathf.Approximately(rgb.velocity.y,0*/)
        {
            if ( ky == true)
            {
                rgb.AddForce(Vector3.up * jumpHeight, ForceMode2D.Impulse);
                ky = false;
            }
            //rgb.velocity=Vector2.up*jumpHeight*100*Time.deltaTime;w
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation= Quaternion.Euler(0f,180f,0f);
        }

        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        //if (Input.GetKeyDown(KeyCode.D)&&kyö==2)
        //{
        //    transform.rotation=Quaternion.Euler(0,0,0);

        //}

        //if (Input.GetKeyDown(KeyCode.A) && kyö == -2)
        //{
        //    kyö *= -1;
        //    transform.rotation = Quaternion.Euler(0, 180f, 0);
        //}
    }


}
