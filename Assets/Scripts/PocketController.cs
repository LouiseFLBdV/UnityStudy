using UnityEngine;

public class PocketController : MonoBehaviour
{
    public GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        gameController.PocketDestroyed = gameController.PocketDestroyed + 1;
        Destroy(other.gameObject);
    }
}
