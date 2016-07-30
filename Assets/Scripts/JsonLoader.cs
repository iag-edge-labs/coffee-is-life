using UnityEngine;
using System.Collections;

public class JsonLoader : MonoBehaviour {

    // Use this for initialization
    void Start () {
        string filePath = "data/buildings";
        TextAsset targetFile = Resources.Load<TextAsset>(filePath);
        
    }

    // Update is called once per frame
    void Update () {

    }
}
