using UnityEngine;

public class ClassworkEx4 : MonoBehaviour
{
    void Start()
    {
        int a = 100;
        int b = 50;
        int sum = a + b;
        int dif = a - b;
        int mult = a * b;
        
        Debug.Log($"a + b: {sum}");
        Debug.Log($"a - b: {dif}");
        Debug.Log($"a * b: {mult}");
    }
}