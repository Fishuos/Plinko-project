using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text scoreDisplay;
    public int Score = 0;

    // Update is called once per frame
    public void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int points)
    {
        Score += points;
        scoreDisplay.text = $"SCORE: {Score,00000000}";
    }

    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = $"SCORE: {Score}";
    }
    
}
