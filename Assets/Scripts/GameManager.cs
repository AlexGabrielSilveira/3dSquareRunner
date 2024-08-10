using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver = false;
    public GameObject CompleteLevelUI;
    public static GameManager Instance { get; private set;}

     private void Awake()
    {  
        if(Instance != null && Instance != this) {
            Destroy(Instance);
        }else {
            Instance = this;
        }
        
    }

    public void GameOver() {
        isGameOver = true;

        if(isGameOver) {
            Invoke("RestartGame", 2f);
        }
    }

    public void RestartGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        CompleteLevelUI.SetActive(true);
    }
}