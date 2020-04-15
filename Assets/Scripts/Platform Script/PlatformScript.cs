using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour{

    public float moveSpeed = 2f;
    public float boundY = 6f;

    public bool movingPlatformLeft, movingPlatformRight, isBreakable, isSpike, isPlatform;

    private Animator anim;

    public GameObject player;

    void Awake(){
        
        if(isBreakable){
            anim = GetComponent<Animator>();
        }

    }

    void Update(){
        Move();
    }

    // Vector2 nilai;

    void Move(){

        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

        if(temp.y >= boundY){
            gameObject.SetActive(false);
        }

    } // void move


    void BreakableDeactivate(){
        Invoke("DeactivateGameObject", 0.2f);
    }

    void DeactivateGameObject(){
        SoundManager.instance.BreakSound();
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Player"){
            if(isSpike){

                HealthScript.instance.decreaseHealth();

                PlayerBounds.instance.MovePlayerUp();

                SoundManager.instance.GameOverSound();

                // GameManager.instance.RestateGame();
            }
        }
    } // void OnTriggerEnter2D


    void OnCollisionEnter2D(Collision2D target) {
        if(target.gameObject.tag == "Player"){

            if(isBreakable){
                SoundManager.instance.LandSound();
                anim.Play("Break");
            }

            if(isPlatform){
                SoundManager.instance.LandSound();
            }

        }
    }

    void OnCollisionStay2D(Collision2D target){
        if(target.gameObject.tag == "Player"){

            if(movingPlatformLeft){
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(-1f);
            }

            if(movingPlatformRight){
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(1f);
            }

        }
    }

}











