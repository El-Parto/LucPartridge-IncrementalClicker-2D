using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public MainControl mainControl;
    public Upgrade lEupgrade; // lE = Laziness Effeciency



    public double clickLevelCost; // A float data type variable which will determine the cost of the players clicking level
    public float cLCMultiplier; // a float data type variable which will multiply the ClickLevelCost
    public float autoClickValue; // a float data type variable which holds the autoClickValue
    public float autoClickRate;// a float data type variable which holds the autoClickRate



   public void StartUpgradeManager()
    {
        clickLevelCost = 50;
        cLCMultiplier = 2;
       // UpdateLEUI();
    }

    /// <summary>
    /// Determines the cost of the upgrade LazinessEffeciency
    /// </summary>
    /// <returns>returns the cost of the Laziness Efficiency upgrade. Where clickLevel = Laziness Effieciency</returns>
    public double lEClickCost()
    {
        return clickLevelCost * (Mathf.Pow(cLCMultiplier, mainControl.gameData.clickingLevel));
    }

    // this will update the UI for Laziness Effeciency each time the script runs, not every frame.
    /*
    void UpdateLEUI()
    {
        lEupgrade.levelText.text = mainControl.gameData.clickingLevel.ToString();
        lEupgrade.costText.text = "Lazy points required \n " + lEClickCost();
    }
    */

    /// <summary>
    /// The function that allows the player to buy the upgrade
    /// </summary>
    public void BuyLazyEffOnClick()
    {
        if (mainControl.gameData.lazyPointsTotal >= clickLevelCost) //if the total accumulated LP is greater than or equal to the cost of lE
        {
            mainControl.gameData.lazyPointsTotal -= clickLevelCost;
            mainControl.gameData.clickingLevel += 1;
        }
        //UpdateLEUI();
    }

}
