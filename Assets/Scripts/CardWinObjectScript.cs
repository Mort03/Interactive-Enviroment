using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardWinObjectScript : MonoBehaviour
{

    public TMP_Text CardWinText;

    private string win = "You won!";


    public void YouWonCardGame()
    {
        CardWinText.text = win;
    }

    public void ShuffleRemoveText()
    {
        CardWinText = null;
    }
    
}
