using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    SceneManager SceneManager;
    public InputField username;
    public InputField password;
    void Start()
    {
      //SceneManager=GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Login()
    {
        if (username.text.Equals("") || password.text.Equals(""))
        {

        }
        else {
            StartCoroutine(GiriþYap());
        }
    }
    IEnumerator GiriþYap()
    {
        WWWForm form = new WWWForm();
        form.AddField("unity", "girisyapma");
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/unityDb/register.php",form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                SceneManager.LoadScene(1);
            }
            else
            {
                if (www.downloadHandler.text.Contains("Giris Basarili"))
                {
                    
                }
            }
        }
        
    }
}
