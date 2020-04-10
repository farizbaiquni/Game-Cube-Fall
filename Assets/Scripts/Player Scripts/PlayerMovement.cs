 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        Move();
    }

    void Move(){

        if(Input.GetAxisRaw("Horizontal") > 0f){
            myBody.velocity = new Vector2 (moveSpeed, myBody.velocity.y);
        }

        Debug.Log(Input.GetAxisRaw("Horizontal"));

        if(Input.GetAxisRaw("Horizontal") < 0f){
            myBody.velocity = new Vector2 (-moveSpeed, myBody.velocity.y);
        }

    }

    public void PlatformMove(float x){
        myBody.velocity = new Vector2 (x, myBody.velocity.y);
    }
}
