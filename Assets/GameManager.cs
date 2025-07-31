using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int score;
    int gold;
    int apples;

    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] TextMeshProUGUI applesText;

    public void AddScore()
    {
        score += 1;
        Debug.Log("Score:" + score);
        if(score >= 10)
        {
            Debug.Log("We won!! yay");
        }
    }

    public void AddGold()
    {
        gold += 1;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void BuyApple()
    {
        if(gold >= 5)
        {
            Debug.Log("Bought Apple");
            apples += 1;
            gold -= 5;
            applesText.text = "Apples: " + apples.ToString();
            goldText.text = "Gold: " + gold.ToString();
        }
        else
        {
            Debug.Log("Sorry too poor TT");
        }
    }
}
