using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MainControl : MonoBehaviour
{
    //[SerializeField]
    //private TMP_Text lazyPointsText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable named lazyPointsText
    [SerializeField]
    private TextMeshProUGUI lazyPointsText;
    [SerializeField]
    private Button button;




    //public GameData gameData; // calls a class

    public LazinessEfficiency lEfficency;

    public double lazyPointsTotal; // declaring a double variable and naming it as lazyPointsTotal - this will be the total score the player has.
    //public double multiplier = 1; // declaring a float variable and naming it as multiplier
    public double increment = 1; // declaring a float variable and naming it as increment

    

   

    


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    public void AddPoints()
    {
        // this will include the function from lEfficency to increse the increment if the upgrade
        // has been clicked
        lEfficency.OnClickBuyLazyEff();
        
        // Adds the "increment" float variable to the double variable "lazyPoints" if the player has a multiplier, then the increment is multiplied by the multiplier.
        lazyPointsTotal = lazyPointsTotal += increment;
        
        


    }

    public void onClickBeLazy()
    {
        AddPoints();
    }


    // Update is called once per frame
    void Update()
    {
        lazyPointsText.text = "Lazy Points \n" + lazyPointsTotal; // makes it so that the text will add the double variable "lazyPoints" (a number) to the text "Lazy points"



    }

}
