using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
     
 
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player") != null ){
            score += 1*Time.deltaTime;
            scoreText.text  = ((int)score).ToString();
        }
    }
}