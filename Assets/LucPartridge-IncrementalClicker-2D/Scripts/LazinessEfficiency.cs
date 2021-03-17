using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LazinessEfficiency : MonoBehaviour
{
    public GameData gameData;

    

    [SerializeField]
    private TMP_Text lazyNameText;
    [SerializeField]
    private TMP_Text lazyLevelText;
    [SerializeField]
    private TMP_Text lazyCostText;

    public double lazyELevel;
    public double lazyECost;

    // Start is called before the first frame update
    void Start()
    {
        lazyELevel = 1;
        lazyECost = 10;
        gameObject.SetActive(false);
    }

    public void triggerActiveLEUpgrade()
    {
        if (gameData.lazyPointsTotal >= lazyECost)
        {
            gameObject.SetActive(true);
        }
    }

    public void OnClickBuyLazyEff()
    {
        if (gameData.lazyPointsTotal >= lazyECost)
        {

            gameData.lazyPointsTotal -= lazyECost;
            lazyELevel += 1;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
