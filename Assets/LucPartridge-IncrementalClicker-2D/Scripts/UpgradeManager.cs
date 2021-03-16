using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public GameData gameData;

    public double clickLevelCost; // A float data type variable which will determine the cost of the players clicking level
    public float cLCMultiplier; // a float data type variable which will multiply the ClickLevelCost
    public float autoClickValue; // a float data type variable which holds the autoClickValue
    public float autoClickRate;// a float data type variable which holds the autoClickRate


    // Start is called before the first frame update
    void Start()
    {
        clickLevelCost = 50;
        cLCMultiplier = 2;
    }


    public double ClickCost()
    {
        return clickLevelCost * (Mathf.Pow(cLCMultiplier, gameData.clickingLevel));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
