using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Networking;
public class FileManager : MonoBehaviour
{
    string path;
    public RawImage image;
    public void OpenExplorer() {
        path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        GetImage();
    }

    void GetImage() {
        if (path != null) {
            StartCoroutine(UpdateImage());
        }
    }
    IEnumerator UpdateImage() {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file:///" + path);
        yield return www.SendWebRequest();
        image.texture = DownloadHandlerTexture.GetContent(www);
        //this code makes images proportionate but often makes it too big
        /*int w=DownloadHandlerTexture.GetContent(www).width;
        int h = DownloadHandlerTexture.GetContent(www).height;
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(w, h);*/
        
    }
}
