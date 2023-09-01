using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class WebRequest : MonoBehaviour {

    void Start() {
        StartCoroutine(Upload());
    }

    IEnumerator Upload() {
        using (UnityWebRequest www = UnityWebRequest.Post("http://172.102.0.63:3000/api/demon/create", "{ \"demon_name\": \"Baphy\", \"zodiac\": \"Capricornio 3\", \"material\": \"Peluche \", \"model\": \"123213243 \"}", "application/json")) {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success) {
                Debug.Log(www.error);
            }
            else {
                Debug.Log("Form upload complete!");
            }
        }
    }
}