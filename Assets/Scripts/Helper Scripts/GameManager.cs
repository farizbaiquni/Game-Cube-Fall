using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    // Start is called before the first frame update
    
    public static GameManager instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    public void RestateGame(){
        Invoke("GameRestateAfterTime", 2f);
    }


    public void GameRestateAfterTime(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("BaseScene");
    }
}
