using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject standartPlatform;
    public GameObject spikePlatform;
    public GameObject[] movingPlatform;
    public GameObject breakablePlatform;
    
    public float platform_Spawn_Initial_Timer = 1.8f;
    public float current_Platform_Spawn_Timer;
    public int platform_Count = 0;
    public float min_X = -2f, max_X = 2f; 

    void Start(){
        current_Platform_Spawn_Timer = platform_Spawn_Initial_Timer;
    }

    void Update(){
        SpawnerPlatform();
    }

    void SpawnerPlatform(){

        current_Platform_Spawn_Timer += Time.deltaTime;

        if(current_Platform_Spawn_Timer >= platform_Spawn_Initial_Timer){

            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            platform_Count++;

            GameObject newPlatform = null;

            if (platform_Count < 2 ){
               
                newPlatform = Instantiate(standartPlatform, temp, Quaternion.identity);
            
            } else if(platform_Count == 2){

                if(Random.Range(0, 2) > 0) {

                    newPlatform = Instantiate(standartPlatform, temp, Quaternion.identity);
                
                } else {
                    
                    newPlatform = Instantiate(movingPlatform[Random.Range(0, movingPlatform.Length)],temp, Quaternion.identity );
                    
                    
                }

            } else if(platform_Count == 3){
                
                if(Random.Range(0,2) > 0) {

                    newPlatform = Instantiate(standartPlatform, temp, Quaternion.identity);

                } else {

                    newPlatform = Instantiate(spikePlatform, temp, Quaternion.identity);
                }

            } else if (platform_Count == 4){

                if(Random.Range(0, 2) > 0){

                    newPlatform = Instantiate(standartPlatform, temp, Quaternion.identity);
                
                } else {

                    newPlatform = Instantiate (breakablePlatform, temp, Quaternion.identity);
               
                }

                platform_Count = 0;

            } 

            if (newPlatform != null){

                newPlatform.transform.parent = transform;
            
            }
            
            current_Platform_Spawn_Timer = 0f;

        }
    } //void spawn platform
}
