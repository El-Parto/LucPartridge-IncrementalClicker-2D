using UnityEngine;
using TMPro;
public class MainControl : MonoBehaviour
{
    [SerializeField]
    private TMP_Text lazyPointsText; // declaring a class - TMP_Text or TextMeshPro_Text - and giving it a variable named lazyPointsText

    public GameData gameData; // calls a class

    public LazinessEfficiency lEfficency;

    // Start is called before the first frame update
    void Start()
    {
        gameData = new GameData();
        
    }

    public void AddPoints()
    {
        // Adds the "increment" float variable to the double variable "lazyPoints" if the player has a multiplier, then the increment is multiplied by the multiplier.
        gameData.lazyPointsTotal += gameData.increment * gameData.multiplier;


    }

    // Update is called once per frame
    void Update()
    {
        lazyPointsText.text = "Lazy Points \n" + gameData.lazyPointsTotal; // makes it so that the text will add the double variable "lazyPoints" (a number) to the text "Lazy points"
        
    }

}
