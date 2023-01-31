using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    AudioSource AD;
    public GameObject kapama, açma;
    public List<AudioClip> audioClips;
    // Start is called before the first frame update
    void Start()
    {
        AD = GetComponent<AudioSource>();
        int r = Random.Range(0, audioClips.Count);
        AudioClip clip = audioClips[r];
        AD.clip = clip;
        AD.Play();
    }

    // Update is called once per frame
    
    public void KAPA()
    {
        
        AD.mute= true;
        kapama.SetActive(false);
        açma.SetActive(true);
    }
    public void aç()
    {
        kapama.SetActive(true);
        açma.SetActive(false);
        AD.mute= false;
    }

}
