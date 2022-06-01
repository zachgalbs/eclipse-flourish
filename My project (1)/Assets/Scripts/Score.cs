using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//public PlayerMovement movement;
public class Score : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Check the value of a variable
            // Set the current time to the new variable
            // stop the game
            Debug.Log("This ran");
            record = false;
            Debug.Log("record is now false");
            if (currentTime>bestTime) 
            { 
                Debug.Log("New Highscore!");
                bestTime = currentTime; 
            }
            if (bestTimeUpdate != null) bestTimeUpdate.text = "Best: " + Mathf.Round(bestTime * 100.0f)/100.0f;

        }
    }   
    public Transform player;
    public Text textToUpdate;
    public Text bestTimeUpdate;
public float currentTime = 0;
public float bestTime = 0;
public bool record = false;
public bool shouldIStop = false;
    void Start()
    {
        //Resetting current stopwatch timer
        currentTime = 0.00f;
        //Starting the time record
        StartRecord();
    }
    // Update is called once per frame
    void Update()
    {
        // Adding to currentTime if record is true, or if we want keeping time
        if (record)
        {
            currentTime += 1*Time.deltaTime;
        }
        if (textToUpdate != null) textToUpdate.text = "Time: " + Mathf.Round(currentTime * 100.0f)/100.0f;
        // If user presses R, restart the game
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
        
    }
     public void RestartGame() {
            public float saveBestTime = bestTime;
            Debug.Log(bestTime); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
            Debug.Log(saveBestTime);
            if (bestTimeUpdate != null) bestTimeUpdate.text = "Best: " + Mathf.Round(bestTime * 100.0f)/100.0f;
     }

    void StartRecord () {
        record = true;
    }
    void StopRecord () {
        Debug.Log("The record is now set to false");
        record = false;
    }
    
}
