using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;

public class WebRequest : MonoBehaviour {
    public string modelPath = "Assets/Models/"; // Ruta donde se guardará el archivo.
    private string byteString = "";

    private void Start() {
        StartCoroutine(Upload());
        StartCoroutine(DownloadModel());
    }

    private IEnumerator Upload() {
        // Ruta del archivo que deseas subir
        byte[] fileData = File.ReadAllBytes(modelPath);
        // Crear un formulario con los datos
        WWWForm form = new WWWForm();
        // Agregar el nombre del modelo como un campo normal
        form.AddField("nombreModelo", "Nombre del Modelo");
        // Agregar el archivo como un campo binario
        form.AddBinaryData("archivo", fileData, Path.GetFileName(modelPath));

        UnityWebRequest www = UnityWebRequest.Post("http://192.168.68.82:3000/subir-archivo", form);
        // No es necesario especificar el tipo de contenido, se asigna automáticamente
        // www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success) {
            Debug.LogError(www.error);
            Debug.Log(www.downloadHandler.text);
        } else {
            Debug.Log("Archivo cargado con éxito");
        }
    }

    private IEnumerator DownloadModel() {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("http://192.168.68.82:3000/descargar-archivo/araña");
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError) {
            Debug.LogError("Error al descargar el Asset Bundle: " + www.error);
        } else {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            if (bundle != null) {
                string rootAssetPath = bundle.GetAllAssetNames()[0];
                print(rootAssetPath);
            }
        }
    }
}

[Serializable]
internal class JsonResult {
    public Data data;
}

[Serializable]
internal class Data {
    public Model model;
}

[Serializable]
internal class Model {
    public byte[] data;
}

public static class JsonHelper {

    public static T[] FromJson<T>(string json) {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    public static string ToJson<T>(T[] array) {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint) {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T> {
        public T[] Items;
    }
}