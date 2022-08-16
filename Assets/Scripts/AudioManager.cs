using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Food SFX")]
    [SerializeField] AudioClip foodSFX;
    [SerializeField] [Range(0f, 1f)] float foodPickUpVolume = 0.5f;

    [Header("Trap SFX")]
    [SerializeField] AudioClip trapSFX;
    [SerializeField] [Range(0f, 1f)] float trapPickUpVolume = 0.7f;

    public void PlayFoodSFX(){
        AudioSource.PlayClipAtPoint(foodSFX, Camera.main.transform.position, foodPickUpVolume);
    }

    public void PlayTrapSFX(){
        AudioSource.PlayClipAtPoint(trapSFX, Camera.main.transform.position, trapPickUpVolume);
    }

}
