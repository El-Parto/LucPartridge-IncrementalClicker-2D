using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Controller : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinTotalText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable
    // this is to make sure we can edit the total coin text while playing


    public GameData gameData; // calls a class refering to the GameData Script

    public Button dispencingButton;

    public CoinDispencer coinDispencer;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void AddPoints()
    {

        // Adds the "increment" float variable to the double variable "lazyPoints" if the player has a multiplier, then the increment is multiplied by the multiplier.
        gameData.coinsTotal = gameData.coinsTotal + gameData.addCoinIncrement;
        

    }

    // Update is called once per frame
    void Update()
    {
        coinTotalText.text = $"Coins  \n {gameData.coinsTotal.ToString("F0")}"; // makes it so that the text will add the the double variable (coinsTotal) to the string
        
        // If your total sum of coins is greater than the upgrade cost
        if(gameData.coinsTotal >= coinDispencer.autoCoinCost)
        {
            dispencingButton.gameObject.SetActive(true); //activate the button game object
        }
    }
}
