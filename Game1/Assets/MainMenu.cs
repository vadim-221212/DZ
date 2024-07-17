using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        ExitButton.onClick.AddListener(ExitGame);
    }

    void StartGame(){
        SceneManager.LoadScene("Level1");

    }
    void ExitGame(){
        Application.Quit();
    }
}
