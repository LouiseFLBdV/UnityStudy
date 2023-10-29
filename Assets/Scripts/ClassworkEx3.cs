using UnityEngine;

public class ClassworkEx3 : MonoBehaviour
{
    void Start()
    {
        int a = 0;
        int b = 1;
        Debug.Log($"a: {a}, b: {b}");
        // ReSharper disable once SwapViaDeconstruction
        int temp = a;
        a = b;
        b = temp;
        Debug.Log("Swap");


        Debug.Log($"a: {a}, b: {b}");
    }
}