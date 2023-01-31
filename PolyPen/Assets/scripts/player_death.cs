using TMPro;
using UnityEngine;

public class player_death : MonoBehaviour
{
    public static Rigidbody2D rb;
    public static Animator anim;
    public TMP_Text hss;
    public GameObject panel;


    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        panel.SetActive(false);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tuzak"))
        {
            ölüm();
            CameraMove.movespeed = 0;
        }
    }

    public static void ölüm()
    {
         
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("ölüm");
        



    }

    public  void ölümbit()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

}
