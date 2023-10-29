using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomNumber : MonoBehaviour
{
    public TMP_InputField text;
    public TMP_Text answer;
    public int hiddenNumber;

    private void Start()
    {
        hiddenNumber = Random.Range(0, 10000);
    }

    public void GuessNumber()
    {
        int number;

        if (int.TryParse(text.text, out number))
        {
            if (hiddenNumber == number)
            {
                answer.text = "You Win";
            } else if (hiddenNumber > number)
            {
                answer.text = "The hidden number is bigger";
            }
            else
            {
                answer.text = "The hidden number is lower";
            }
        }
        else
        {
            answer.text = "Your text is not number";
        }
    }
}