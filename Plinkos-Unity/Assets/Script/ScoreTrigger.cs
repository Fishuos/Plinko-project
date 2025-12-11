using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ScoreKeeper scoreKeeper;
    public int points = 0;
    
    public bool useMultiplier = false;
    public float multiplier = 1f;
    
    public bool useDivider = false;
    public float Divider = 1f;
    private void OnTriggerEnter2D(Collider2D collider)
    {
      

        if (useMultiplier)
        {
            points = Mathf.RoundToInt(scoreKeeper.Score * multiplier);
        }
        if (useDivider)
        {
            points = Mathf.RoundToInt(scoreKeeper.Score / Divider);
        }

        scoreKeeper.AddScore(points);



        Destroy(collider.gameObject);
    }
}
