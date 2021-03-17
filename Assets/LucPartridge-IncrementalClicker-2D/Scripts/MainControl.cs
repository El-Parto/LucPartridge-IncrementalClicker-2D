using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
    [SerializeField]
    private TMP_Text lazyPointsText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable named lazyPointsText
    [SerializeField]
    private TMP_Text leEfficiencyText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable named lazyPointsText




    public GameData gameData; // calls a class
    public UpgradeManager upgradeManager;


    public float TotalEfficiency()
    {
       return gameData.increment += gameData.clickingLevel;
    }


    // Start is called before the first frame update
    void Start()
    {
        gameData = new GameData();
        upgradeManager.StartUpgradeManager();

    }

    /// <summary>
    /// This is where we add points to our total
    /// </summary>
    public void AddPoints()
    {
        // Adds the "increment" float variable to the double variable "lazyPoints" if the player has a multiplier, then the increment is multiplied by the multiplier.
        gameData.lazyPointsTotal += TotalEfficiency();


    }
    /*
    public void AutoPoints()
    {

    }
    */
    // Update is called once per frame
    void Update()
    {
        lazyPointsText.text = "Lazy Points \n" + gameData.lazyPointsTotal; // makes it so that the text will add the double variable "lazyPoints" (a number) to the text "Lazy points"
        //lazyPointsText.text = "Lazy Points \n" + TotalEfficiency(); // makes it so that the text will add the double variable "lazyPoints" (a number) to the text "Lazy points"
>>>>>>> Stashed changes
    }
}
