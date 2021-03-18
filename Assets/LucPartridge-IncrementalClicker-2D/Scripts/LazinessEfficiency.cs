using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LazinessEfficiency : MonoBehaviour
{
    public MainControl mainControl;

    

    [SerializeField]
    private TMP_Text lazyNameText;
    [SerializeField]
    private TMP_Text lazyLevelText;
    [SerializeField]
    private TMP_Text lazyCostText;

    public double lazyELevel = 1;
    public double lazyECost = 10;


    //public double lazyEAdd;

    // Start is called before the first frame update
    void Start()
    {

        gameObject.SetActive(false);
    }

    public void triggerActiveLEUpgrade()
    {
        if (mainControl.lazyPointsTotal >= lazyECost)
        {
            gameObject.SetActive(true);
        }
    }


    /// <summary>
    /// When you click the button, if your current score is greater than or equal to
    /// the cost of the upgrade, subtract the cost of the upgrade
    /// </summary>
    public void OnClickBuyLazyEff()
    {
        triggerActiveLEUpgrade();

        if (mainControl.lazyPointsTotal >= lazyECost) // if points obtained greater than or equal to cost
        {
            mainControl.lazyPointsTotal -= lazyECost; // subtract cost here
            lazyELevel += 1; // increase level by 1
            mainControl.increment = mainControl.increment++; // This SHOULD increase the increment value in MainControl by 1 each time you press the button
        }
        lazyECost = lazyELevel * lazyECost;  // cost is now multiplied by the level
        
       
    }




    
}
