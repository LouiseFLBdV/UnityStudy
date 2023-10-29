using TMPro;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public TMP_Text result;
    void Start()
    {
        string temporaryResult = "";
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                temporaryResult += i + "; ";
            }
            
        }

        result.text = temporaryResult;
    }
}
