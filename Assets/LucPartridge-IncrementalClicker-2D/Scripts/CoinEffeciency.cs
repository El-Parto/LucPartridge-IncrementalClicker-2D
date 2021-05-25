using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinEffeciency : MonoBehaviour
{
    public GameData gameData;


    [SerializeField]
    private float costMult = 2f;

    public float coinEfCost = 20;


    [SerializeField]
    private float effeciencyIncrement = 1f;



    [SerializeField]
    private TMP_Text costText;


    // Start is called before the first frame update
    void Start()
    {
        gameData = FindObjectOfType<GameData>();
    }

    // Update is called once per frame
    void Update()
    {

        costText.text = $"Coins required \n {coinEfCost.ToString("F0")}";
    }

    public void Clicked()
    {
        gameData.coinsTotal = gameData.coinsTotal - coinEfCost; // You're paying for the upgrade here, cost takes away from coinsTotal

        coinEfCost = coinEfCost * costMult; // the cost of the upgrade is then multiplied by the multiplier variable
        costMult++; // and the multiplier variable is then incremented as well for additional sanity points.
        gameData.addCoinIncrement++; // the variable for adding coins is incremented

    }
}
