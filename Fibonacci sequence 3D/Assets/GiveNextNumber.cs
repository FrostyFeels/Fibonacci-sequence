using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveNextNumber : MonoBehaviour
{
    private long[] previousNumbers = new long[2];
    private long currentNumber;


    private int firstNumber = 0;
    private int secondNumber = 1;

    public Text currentNumberText;
    public Text previousNumbersText;

    private int numberOfClicks;

    public void Start()
    {
        previousNumbers[0] = firstNumber;
        previousNumbers[1] = secondNumber;
    }

    public void GiveNextSequence()
    {
        //first 2 numbers dont have previous numbers to add up
        if(numberOfClicks < 1)
        {
            currentNumberText.text = firstNumber.ToString();
            numberOfClicks++;
            return;

        } else if(numberOfClicks < 2)
        {
            currentNumberText.text = secondNumber.ToString();
            numberOfClicks++;
            return;
        }

        //change currentnumber with the next number of the sequence
        currentNumber = previousNumbers[0] + previousNumbers[1];

        //set the text to the corrosponding numbers
        previousNumbersText.text = previousNumbers[0].ToString() + " , " + previousNumbers[1].ToString();
        currentNumberText.text = currentNumber.ToString();

        //Change the last 2 numbers that were added.
        previousNumbers[0] = previousNumbers[1];
        previousNumbers[1] = currentNumber;


    }

}
