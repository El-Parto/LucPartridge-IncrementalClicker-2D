using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinDispencer : MonoBehaviour
{

    // this script increases the amount of coins you earn automatically by clicking the button associated with this script

    public GameData gameData;
    //private Controller controller;

    public Button dispencerButton;
    
    //setting up cost variables
    [SerializeField]
    private float costMult = 2f;

    public float autoCoinCost = 20;


    [SerializeField]
    private float dispencingIncrement = 0;

    public bool dispencingCoins = false;

    [SerializeField]
    private TMP_Text costText;

    public void Start()
    {
        gameData = FindObjectOfType<GameData>();
    }


    public void Update()
    {
        if (dispencingCoins == true)
        {
            gameData.coinsTotal += dispencingIncrement * Time.deltaTime;
        }

        costText.text = $"Coins required \n {autoCoinCost.ToString("F0")}";// the text for the cost of the upgrade
        if (gameData.coinsTotal >= autoCoinCost)
        {
            dispencerButton.gameObject.SetActive(true);
        }
    }
    public void WhenClicked()
    {
        // when the button associated with this function is clicked
        // and if your current coin total is equal to or greater than the cost
        if (gameData.coinsTotal >= autoCoinCost)
        {
            gameData.coinsTotal = gameData.coinsTotal - autoCoinCost; // subtract the dispencer cost from your total coins (coinsTotal)

            autoCoinCost = costMult * autoCoinCost; //sets cost of the future upgrade by using the multiplier variable
            costMult++; //setting multiplier value for this function
            dispencingIncrement++; // the value of dispencingIncrement is incremented
            dispencingCoins = true; // setting the bool for dispencing coins to be true so we can rake in the dosh.

        }
    }


}
