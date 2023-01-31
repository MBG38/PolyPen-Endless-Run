using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarkıtmanager : MonoBehaviour
{
    [SerializeField] GameObject sarkit;

    [SerializeField] List<Transform> spawnpoz = new List<Transform>();

    private float atis_zamani=3;
    private float zaman = 10;

    private void Start()
    {
        foreach (Transform t in transform)
        {
            spawnpoz.Add(t);
        }
        StartCoroutine(Timer());

    }
    private void Update()
    {
        atisart();
    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(atis_zamani);
            int a = Random.Range(0, spawnpoz.Count);
            Instantiate(sarkit, spawnpoz[a].position, Quaternion.identity);

        }
        
    }
    private void atisart()
    {
        if (zaman > 1)
        {
            zaman -= Time.deltaTime;
        }
        else if (atis_zamani<1.5f)
        {
            zaman += 1000;
        }
        else if(zaman < 1&&atis_zamani>=1f) 
        {
            atis_zamani -= 0.3f;
            zaman = 10;
        }

    }
}
