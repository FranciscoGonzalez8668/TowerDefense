using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandeler : MonoBehaviour
{

    [SerializeField] private FadeManager FadeManager;

    public void StartGame()
    {
        FadeManager.FadeToScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    

}
