using TMPro;
using UnityEngine;

public class Prestige : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public TMP_Text prestigeDisplay;
    public TMP_Text tillPrestigeDisplay;


    int publicPrestige = 0;
    int privatePrestige = 1;

    void Start()
    {

        
        UpdatePrestigeDisplay();
    }
   
        
       


    public void DoPrestige()
    {

       //displays current prestige
        prestigeDisplay.text = $"Prestige: {publicPrestige,00000000}";


        // introduces all of the games scalling features
        if (scoreKeeper.Score >= 100 * privatePrestige)
        {
            Debug.Log("DoPrestige triggered");
            scoreKeeper.increaser++;
            privatePrestige++;
            publicPrestige++;
            UpdatePrestigeDisplay();
            scoreKeeper.Score = 0;
            scoreKeeper.UpdateScoreDisplay();
        }
    }

    public void UpdatePrestigeDisplay()
    {
        if (prestigeDisplay != null)
            prestigeDisplay.text = $"Prestige: {publicPrestige}";

       
    }
   


}
