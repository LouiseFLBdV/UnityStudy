using TMPro;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public TMP_Text result;
    private int page;
    void Start()
    {
        string temporaryResult = "";
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                temporaryResult += $"{i} * {j} = {i * j}\n";
            }
        }

        result.text = temporaryResult;
    }

    public void NextPage()
    {
        result.pageToDisplay++;
        if (result.pageToDisplay > result.textInfo.pageCount)
        {
            result.pageToDisplay = 1;
        }
    }
    public void PrevPage()
    {
        result.pageToDisplay--;
        if (result.pageToDisplay < 0 )
        {
            result.pageToDisplay = result.textInfo.pageCount;
        }
    }
}