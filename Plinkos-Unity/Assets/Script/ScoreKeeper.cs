using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text scoreDisplay;
    public int Score = 0;
    
    public Prestige prestige;
    public int increaser = 1;
    // Update is called once per frame
    public void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int points)
    {
        
        if (prestige != null)
            increaser = Mathf.Max(1, increaser);

        Score += points * increaser;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        if (scoreDisplay != null)
            scoreDisplay.text = $"SCORE: {Score,00000000}";
    }
    
}
