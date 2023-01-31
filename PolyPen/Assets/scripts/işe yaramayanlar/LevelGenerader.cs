using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class LevelGenerader : MonoBehaviour
{
    private const float oyuncu_spawn_yeri = 200f;

    [SerializeField] private Transform baslangic;
    [SerializeField] public List<Transform> haritaliste;
    [SerializeField] private Player player;
    int baslangic_harita_say = 2;

    


    private Vector3 son_nokta;

    

   


    private void Awake()
    {
        
        son_nokta = baslangic.Find("haritabitis").position;

        

        for (int i = 0; i < baslangic_harita_say; i++)
        {
            harita_olusturmak();
        }
    }

    
    private void Update()
    {
        //Player player=new Player();

        //if (Vector3.Distance(player.GameObject(), son_nokta) < oyuncu_spawn_yeri)
        //{
        //    harita_olusturmak();
        //}
    }
    //bool oistmm=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        harita_olusturmak();

    }

    public void harita_olusturmak()
    {
        Transform haritasecme= haritaliste[Random.Range(0,haritaliste.Count)];
        Transform sonharitatransform = harita_olusturma(haritasecme, son_nokta);
        son_nokta = sonharitatransform.Find("haritabitis").position;
        return;
        
    }
    public Transform harita_olusturma(Transform levelpart,Vector3 spawnposition)
    {
        Transform transformharita=Instantiate(levelpart,spawnposition,Quaternion.identity);    

        return transformharita;
    }
}
