using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public GameObject currentScreen;

    public void OnStateChanged(GameObject screen)
    {
        currentScreen.SetActive(false);
        currentScreen = screen;
        currentScreen.SetActive(true);
    }   
}
