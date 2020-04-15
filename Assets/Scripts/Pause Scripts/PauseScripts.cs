using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScripts : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    public GameObject Button;

    public Button resumeButton;
    public Button falseButton;

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){

            if(GameIsPaused){
        
                Resume();
            
            } else {
            
                Pause();
            
            }
        }
    }

    public void Resume(){
        falseButton.Select();
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        PauseMenuUI.SetActive(true);
        resumeButton.Select();
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void RestateGame(){
        
    }

    public void MainMenuGame(){

    }

}
