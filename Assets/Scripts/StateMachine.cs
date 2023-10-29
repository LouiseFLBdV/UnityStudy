using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class StateMachine : MonoBehaviour
{
    public GameObject start;
    public GameObject finish;
    public GameObject currentScreen;

    void Start()
    {
        start.SetActive(true);
        currentScreen = start;
    }

    public void ChangeState(GameObject screen)
    {
        currentScreen.SetActive(false);
        currentScreen = screen;
        currentScreen.SetActive(true);
    }
}
