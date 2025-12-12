using UnityEngine;
using TMPro;
public class TIllPrestige : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ScoreKeeper scoreKeeper;
    public TMP_Text tillPrestigeDisplay;

    public void Update()
    {
        CanPrestige();
    }


    public void CanPrestige()
    {
       
        //displays wether you can prestige or not
        if (scoreKeeper.Score >= 100 * scoreKeeper.increaser)
        {
                tillPrestigeDisplay.text = $"Can Prestige!";
        }
        else
        {
            tillPrestigeDisplay.text = "Need More Points!";
        }
    }
}
