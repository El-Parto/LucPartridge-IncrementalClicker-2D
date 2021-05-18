using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;


public class Controller : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinTotalText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable
    // this is to make sure we can edit the total coin text while playing


    public GameData gameData; // calls a class refering to the GameData Script

    public CoinDispencer dispencer;



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
        coinTotalText.text = "Lazy Points \n" + gameData.coinsTotal; // makes it so that the text will add the the double variable (coinsTotal) to the string

    }
}
