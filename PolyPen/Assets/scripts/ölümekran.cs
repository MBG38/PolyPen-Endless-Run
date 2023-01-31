using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ölümekran : MonoBehaviour
{
    private float sıfır = 0;
    public void tekrar()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
       
    }

    public void çık()
    {
        SceneManager.LoadScene("anamenu");
    }
    public void scor_sıfırlama()
    {
        //PlayerPrefs.GetFloat(nameof("high_score"), sıfır);
    }


}
