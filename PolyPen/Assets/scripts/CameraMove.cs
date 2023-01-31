using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    
    public static float movespeed;
    Animator anim;
    public float timer ;
    public GameObject bas;
    //public Vector3 offset;
    //public Transform player;

    private void Start()
    {
        Time.timeScale = 0;
        movespeed = 0;
        anim= GetComponent<Animator>();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)&&ScoreMn.score==0)
        {
            bas.SetActive(false);
            Time.timeScale = 1; 
            movespeed = 4;
            Debug.Log("d");
        }

        if (timer >0)
        {
            timer-= Time.deltaTime*1;
        }
        else if (timer<1)
        {
            timer += 2;
            movespeed += 0.5f;
        }
        Hareket();
        //transform.position = Vector3.Lerp(transform.position, player.transform.position+offset, movespeed*Time.deltaTime);
    }
    private void Hareket()
    {    
        this.transform.Translate(movespeed * Time.deltaTime, 0, 0); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player_death.ölüm();
        }
    }


}
