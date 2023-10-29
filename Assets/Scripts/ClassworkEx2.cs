using UnityEngine;

public class ClassworkEx2 : MonoBehaviour
{
    void Start()
    {
        string goodsName = "Monitor";
        int goodsQuantity = 10;
        float goodsPrice = 299.99f;
        
        Debug.Log($"Name: {goodsName}, price {goodsPrice}, quantity {goodsQuantity}");
    }
}
