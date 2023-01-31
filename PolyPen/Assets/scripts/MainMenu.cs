using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject k_ge;
    public GameObject basla; 
    public GameObject c�k;
    private void Start()
    {
        k_ge.SetActive (false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void OnApplicationQuit()
    {
        Debug.Log("OYUNDAN �IKTIN");
        Application.Quit();
    }

    public void k_g_ac()
    {
        k_ge.SetActive(true);
        basla.SetActive(false);  
        c�k.SetActive(false);
    }
    public void k_g_kapa()
    {
        k_ge.SetActive(false);
        basla.SetActive(true);
        c�k.SetActive(true);
    }
}
