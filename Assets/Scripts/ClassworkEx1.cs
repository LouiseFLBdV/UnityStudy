using UnityEngine;

public class ClassworkEx1 : MonoBehaviour
{
    void Start()
    {
        const string helloWorld = "Hello World";
        int a = 0, b = 1, c = 2;
        
        Debug.Log(helloWorld);
        Debug.Log($"a = {a}, b = {b}, c = {c}");
    }
}
