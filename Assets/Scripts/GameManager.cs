using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // to only have one

    // Basically this is absrtraction making a method and to use it just call that method
    public void StartGame() // i use public for this first
    {
        SceneManager.LoadScene(1);
    }

    private void Awake() // this is the code to not destroy the gamemanager and instance
    {
        // Ensure only one instance of the MainManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this GameObject
            Destroy(gameObject);
        }
    }

}
