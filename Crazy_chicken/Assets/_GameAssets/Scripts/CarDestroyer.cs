using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDestroyer : MonoBehaviour
{
    void OnCollisionEnter(Collision c){
        print("Collision...");
        if (c.gameObject.CompareTag("Player")){
            SceneManager.LoadScene(0);
        }
    }

}
