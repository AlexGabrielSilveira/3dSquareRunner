using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public void OpenScene() {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
}
