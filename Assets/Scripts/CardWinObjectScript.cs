using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardWinObjectScript : MonoBehaviour
{

    public TMP_Text CardWinText;

    private string win = "You won!";
    

    //This will activate by a line of code in "CardScript"
    public void YouWonCardGame()
    {
        CardWinText.text = win;
    }
    //This will activate by a line of code in "CardScript"
    public void ShuffleRemoveText()
    {
        CardWinText = null;
    }
    
}
