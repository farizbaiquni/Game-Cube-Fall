using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static SoundManager instance;

    [SerializeField]
    private AudioSource soundFX;
    
    [SerializeField]
    private AudioClip landClip, deathClip, breakClip, gameOverClip;


    void Awake() {
        if(instance == null){
            instance = this;
        }
    }

    public void LandSound(){
        soundFX.clip = landClip;
        soundFX.Play();
    }
    
    public void BreakSound(){
        soundFX.clip = breakClip;
        soundFX.Play();
    }

    public void deathSound(){
        soundFX.clip = deathClip;
        soundFX.Play();
    }

    public void GameOverSound(){
        soundFX.clip = gameOverClip;
        soundFX.Play();
    }

    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
