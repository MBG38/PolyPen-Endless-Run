using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreMn : MonoBehaviour
{
    public TMP_Text hs;
    public float saniydekiscor, scoreF;
    public static float high_score;
    public static int score;
    private TextMeshPro yaz�;
    private float zaman=2;

    private void Start()
    {
        score= 0;
        yaz� = GetComponent<TextMeshPro>();
        PlayerPrefs.GetFloat(nameof(high_score), high_score);
        
    }
    private void Update()
    {
        if (CameraMove.movespeed>=4)
        {
            score = Convert.ToInt32(scoreF);
            scoreF += saniydekiscor * Time.deltaTime;
            yaz�.text = ("SCORE: ") + score.ToString();
            scor_art�r();
        }
        if (scoreF>PlayerPrefs.GetFloat(nameof(high_score), high_score))
        {
            high_score = score;
            PlayerPrefs.SetFloat(nameof(high_score), high_score);
        }

        hs.text = PlayerPrefs.GetFloat(nameof(high_score)).ToString();
        
    }

    private void scor_art�r()
    {
        if (zaman>0)
        {
            zaman-=Time.deltaTime;
        }
        else
        {
            saniydekiscor += 10f;
            zaman = 2;
        }
    }


}
