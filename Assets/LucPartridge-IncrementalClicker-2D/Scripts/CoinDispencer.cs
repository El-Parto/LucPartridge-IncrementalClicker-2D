using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDispencer : MonoBehaviour
{

    // this script increases the amount of coins you earn  by clicking the  main button.

    private GameData gameData;
    private Controller controller;


    [SerializeField]
    private float costMult;

    [SerializeField]
    private float dispencer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WhenClicked();
    }



    public void WhenClicked()
    {
        // when the button associated with this function is clicked
        // and if your current coin total is equal to or greater than the cost
        if (gameData.coinsTotal >= gameData.autoCoinCost)
        {
            gameData.coinsTotal = gameData.coinsTotal - gameData.autoCoinCost; // subtract the dispencer cost from your total coins (coinsTotal)


            
            gameData.multiplier = 2; //setting multiplier value for this function

            gameData.autoCoinCost = gameData.multiplier * gameData.autoCoinCost; //sets cost of the future upgrade by using the multiplier variable


            dispencer++;//  dispencer is adding 

            gameData.coinsTotal = gameData.coinsTotal + dispencer * Time.deltaTime;
        }
    }

    public void DispencingCoins()
    {
       

    }


}
