using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        print("Loading Scene: Level_1");
        SceneManager.LoadScene("Level_1");
    }
}
