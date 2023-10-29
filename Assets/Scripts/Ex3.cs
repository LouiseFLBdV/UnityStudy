using System;
using TMPro;
using UnityEngine;

public class Ex3: MonoBehaviour
{
    public TMP_Text result;
    public TMP_InputField input;

    public void CalcFactorial()
    {
        if (int.TryParse(input.text, out var number))
        {
            int temporaryResult = 1;
            for (int i = 1; i <= number; i++)
            {
                temporaryResult *= i;
            }
            result.text =  $"!{number} = {temporaryResult}";
        }
    }
}