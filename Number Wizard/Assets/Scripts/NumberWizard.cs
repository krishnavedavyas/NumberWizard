using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

   [SerializeField] int min;
    [SerializeField]int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        StartGame();
       
    }
    void StartGame()
    {
      
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
        max++;
    }
    public void OnPressingHigher()
    {
        min = guess;
        NextGuess();
    }
    public void OnPressingLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}
