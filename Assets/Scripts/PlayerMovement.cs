using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce = 6;
    private Audiomanager AudioManager;

    private void Start()
    {
        AudioManager = FindObjectOfType<Audiomanager>();
    }
    private void OnCollisionEnter (Collision collision)
    {
        AudioManager.Play("Bounce");
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounceForce, playerRB.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if(materialName == "Safe (Instance)")
        {
            //The ball hits the Safe Area
        }
        else if(materialName == "Unsafe (Instance)")
        {
            //The ball hits the Unsafe area
            GameManager.gameOver = true;
            AudioManager.Play("Game Over");

        }
        else if(materialName == "LastRing (Instance)")
        {
            //Level CoSmpletion
            GameManager.levelCompleted = true;
            AudioManager.Play("Win Level");
        }
    }
}
