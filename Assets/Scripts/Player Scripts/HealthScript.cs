using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public GameObject health1, health2, health3, health4, health5;

    public static int health;

    public static HealthScript instance;

    // Start is called before the first frame update
    void Start(){

        if(instance == null){
            instance = this;
        }

        health = 3;
        health1.SetActive(true);
        health2.SetActive(true);
        health3.SetActive(true);
        health4.SetActive(false);
        health5.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        
        if(health > 5) {
            health = 5;
        } else if(health < 0){
            health = 0;
        }

        switch (health){

        case 0:
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
            break;

        case 1:
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
            break;

        case 2:
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
            break;

        case 3:
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(false);
            health5.SetActive(false);
            break;

        case 4:
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(true);
            health5.SetActive(false);
            break;

        case 5:
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
            health4.SetActive(true);
            health5.SetActive(true);
            break;

        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Heart"){
            health += 1;
        }
    }

    public void decreaseHealth(){
        health -= 1;
    }
}
