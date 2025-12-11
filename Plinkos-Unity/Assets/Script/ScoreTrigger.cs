using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public ScoreKeeper scoreKeeper;
    public int points = 0;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        scoreKeeper.AddScore(points);
        Destroy(collider.gameObject);
    }
}
