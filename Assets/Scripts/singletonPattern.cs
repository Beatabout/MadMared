using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonPattern : MonoBehaviour
{
    void Awake() {
        int instanses =  FindObjectsOfType<singletonPattern>().Length;
        if(instanses > 1){
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}
