using UnityEngine;

public class PrestigeOnClick : MonoBehaviour
{
    public Prestige prestige;

    public void OnButtonClick()
    {
        prestige.DoPrestige();
    }
}
