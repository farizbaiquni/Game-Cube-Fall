﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour{

    public float moveSpeed = 2f;
    public float boundY = 6f;

    public bool movingPlatformLeft, movingPlatformRight, isBreakable, isSpike, isPlatform;

    private Animator anim;

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

        // nilai.y += Time.deltaTime;
        // Debug.Log(nilai);

        // if(temp.y >= boundY){
        //     gameObject.SetActive(false);
        // }

    }

}











