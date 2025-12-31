using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;

    public void OnScoreZoneReached(int id)
    {
        if(id == 1)
        {
            scorePlayer1++;
        }
        if (id == 2)
        {
            scorePlayer2++;
        }

        UpdateScores();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateScores()
    {
        scoreTextLeft.SetScore(scorePlayer1);
        scoreTextRight.SetScore(scorePlayer2);   
    }
}
