using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject gameScreen;
    public GameObject winScreen;
    public GameObject loseScreen;
    void Start()
    {
        currentScreen.SetActive(true);
    }

    public void ChangeScreen(GameObject screen)
    {
        currentScreen.SetActive(false);
        currentScreen = screen;
        currentScreen.SetActive(true);
    }
}
