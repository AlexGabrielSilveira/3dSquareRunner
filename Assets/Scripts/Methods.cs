using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Methods : MonoBehaviour
{
    public GameObject LevelSelectUI;
    private int menu = 0;
     public void GoToMenu() {
        SceneManager.LoadScene(menu);
        Time.timeScale = 1;
    }

    public void Quit() {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void OpenUI() {
        LevelSelectUI.SetActive(true);
    }
}
