using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.67f;
    public float movSpeed = 1f;
    private float startX = 0f;
    public float maxStartY = 4f;
    // Start is called before the first fame update
    void Start()
    {
        Vector2 direc = Random.value < 0.5f ? Vector2.left : Vector2.right;
        direc.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.velocity = direc * movSpeed;
    }

    private void ResetBall()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZoneScript scoreZone = collision.GetComponent<ScoreZoneScript>(); //Scriptname variable = collision.GetComponent<scriptname>();
        if(scoreZone)
        {
            gameManager.OnScoreZoneReached(scoreZone.id);
            //  UnityEngine.Debug.Log("Scored!");
             ResetBall();
             Start();
        }
    }
}
