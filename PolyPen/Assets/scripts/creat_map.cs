using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creat_map :MonoBehaviour
{
    [SerializeField] List<GameObject> mapParts;
    [SerializeField] Vector3 offset;
    bool isCreated = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isCreated)
        {
           int rn =  Random.Range(0, mapParts.Count);
            Instantiate(mapParts[rn], new Vector3(transform.position.x, transform.position.y, transform.position.z) + offset, Quaternion.identity);
            isCreated = true;
        }
        if (collision.name == "Destroyer")
        {
            
            Destroy(transform.parent.gameObject,1f);
        }
    }





















    //[SerializeField] public List<Transform> haritaliste;
    //private Vector3 son_nokta;
    //public void harita_olusturmak()
    //{
    //    Transform haritasecme = haritaliste[Random.Range(0, haritaliste.Count)];
    //    Transform sonharitatransform = harita_olusturma(haritasecme, son_nokta);
    //    son_nokta = sonharitatransform.Find("haritabitis").position;
    //    return;

    //}
    //public Transform harita_olusturma(Transform levelpart, Vector3 spawnposition)
    //{
    //    Transform transformharita = Instantiate(levelpart, spawnposition, Quaternion.identity);

    //    return transformharita;
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    harita_olusturmak();
    //}


}
