using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PlayAgainMenu;
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text scoreText;

    private void Start() {
        Time.timeScale = 1;
        PlayAgainMenu.SetActive(false);
    }

    public void ReloadStats(int health, int score){
        UpdateHealth(health);
        UpdateScore(score);
    }

    void UpdateHealth(int health){
        healthText.text = new string($"Health: {health.ToString("00")}");
        if(health <= 0){
            Invoke("EndGame", 0.5f);
        }
    }

    void EndGame(){
        Time.timeScale = 0;
        PlayAgainMenu.SetActive(true);
    }

    void UpdateScore(int score){
        scoreText.text = new string($"Score: {score.ToString("000000")}");
    }

    public void OnPlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnQuit(){
        Application.Quit();
    }
}
