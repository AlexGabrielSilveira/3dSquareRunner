using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }   
}
