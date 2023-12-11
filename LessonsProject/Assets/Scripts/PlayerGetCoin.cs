using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class PlayerGetCoin : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision Yep");
        if (other.gameObject.tag == "Player")
        {
            int scoreInt = Convert.ToInt32(score.text.Replace("Score: ", ""));
            score.text = "Score: " + ++scoreInt;
            Destroy(gameObject);
        }
    }
}
