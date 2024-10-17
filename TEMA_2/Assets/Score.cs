using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public int score = 0; 
    public Text scoreText; 
    private bool hasBeenHit = false; 

    void Start()
    {
        UpdateScoreUI(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasBeenHit && collision.gameObject.CompareTag("Bat"))
        {
            print("Ball has been hit!");
            AddScore(40); 
            hasBeenHit = true; 
        }
    }

    void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
        ResetHit();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void ResetHit()
    {
        hasBeenHit = false;
    }
}
