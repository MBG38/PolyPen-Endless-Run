using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public GameObject player;

    public Vector3 GetPosition()
    {

        //player = GameObject.FindGameObjectWithTag("Player");
        return player.transform.position;
    }
}
