using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class register : MonoBehaviour
{
    public InputField username,password;

    public void �yeli�iOlu�tur()
    {
        if (username.text.Equals("")|| password.text.Equals(""))
        {

        }
        else
        {
            if (password.text.Equals(""))
            {
                Debug.Log("vt ba�lantisi");
                StartCoroutine(kay�tol());            }
        }
    }
    IEnumerator kay�tol() {
        WWWForm form = new WWWForm();
        form.AddField("unity", "kay�tolma");
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/unityDb/register.php",form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError||www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Sorgu Sonucu : " + www.downloadHandler.text);
            }
        }
    }

}
