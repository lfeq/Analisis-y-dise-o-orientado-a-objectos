using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.PlayerLoop;

public class WebRequest : MonoBehaviour
{
    void Start()
    {
        // A correct website page.

        // A non-existing page.
        //StartCoroutine(GetRequest("https://error.html"));
    }

    void Update()
    {
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
        StartCoroutine(GetRequest("http://10.2.0.51:3000/"));
    }
    

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }
}
