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
    private float effeciencyIncrement = 0.1f;

    

    [SerializeField]
    private TMP_Text costText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
