using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int health = 3;
    [SerializeField] int score = 0;

    GameManager gameManager;
    AudioManager audioManager;

    private void Start() {
        audioManager = FindObjectOfType<AudioManager>();
        gameManager = FindObjectOfType<GameManager>();
        
        gameManager.ReloadStats(health, score);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Trap"){
            health -= 1;
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            audioManager.PlayTrapSFX();
            Destroy(other.gameObject, 0.5f);
        } else 
        if(other.tag == "Food"){
            score += 1;
            other.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            audioManager.PlayFoodSFX();
            Destroy(other.gameObject, 0.5f);
        } 
        gameManager.ReloadStats(health, score);
    }

}