using UnityEngine;
using TMPro;

public class Prestige : MonoBehaviour
{
    public ScoreKeeper scoreKeeper; 
    public TMP_Text prestigeDisplay;

    
    int publicPrestige = 0;
    int privatePrestige = 1;

    void Start()
    {
       

        UpdatePrestigeDisplay();
    }

    

    public void DoPrestige()
    {
        

        prestigeDisplay.text = $"Prestige: {publicPrestige,00000000}";

        if (scoreKeeper.Score >= 100 * privatePrestige)
        {
            Debug.Log("DoPrestige triggered");
            scoreKeeper.increaser++;
            privatePrestige++;
            publicPrestige++;
            UpdatePrestigeDisplay();
        }
    }

    public void UpdatePrestigeDisplay()
    {
        if (prestigeDisplay != null)
            prestigeDisplay.text = $"Prestige: {publicPrestige}";
    }

   
   
}
