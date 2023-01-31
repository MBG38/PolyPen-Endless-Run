using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class register : MonoBehaviour
{
    public InputField username,password;

    public void ÜyeliğiOluştur()
    {
        if (username.text.Equals("")|| password.text.Equals(""))
        {

        }
        else
        {
            if (password.text.Equals(""))
            {
                Debug.Log("vt bağlantisi");
                StartCoroutine(kayıtol());            }
        }
    }
    IEnumerator kayıtol() {
        WWWForm form = new WWWForm();
        form.AddField("unity", "kayıtolma");
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
