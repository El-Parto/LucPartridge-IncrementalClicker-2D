using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public float coinsTotal; // declaring a double variable and naming it as lazyPointsTotal - this will be the total score the player has.
    //top where the title is

    public float multiplier;
    // the multiplier for the cost
    public float addCoinIncrement = 1f; // declaring a float variable, this is how much the "points" go up by each time clicked
    // the incremental value of your clicks affected by Coin Effenciency.
    public float coinELevel = 1;
    // the effeciency level of clicks, this doesn't effect increment , but does tell the player the level of coin per click.


    //public float autoCoinCost = 20; // base cost  variable for CoinDispencer

    public float coinECost = 10;// base cost variable for AddCoins



}
