using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartScript : MonoBehaviour
{
    public float boundY = 6f;

    // Update is called once per frame
    void Update(){

        Vector2 temp = transform.position;

        if(temp.y >= boundY){

            gameObject.SetActive(false);

        }
    }

    void OnCollisionEnter2D(Collision2D target) {
            
        if(target.collider.tag == "Player"){
        
            gameObject.SetActive(false);       
        }
    }
}
