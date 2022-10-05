using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// if you need to be sure 
// that only 1 instance of the object 
// will exist durin all the game 
// and wont be destroyed inbetween scenes
// you need to use Singleton Pattern

public class SingletonPattern : MonoBehaviour
{
    void Awake() {
        int instanses =  FindObjectsOfType<SingletonPattern>().Length;
        if(instanses > 1){
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}



