using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float _pocketDestroyed = 0;
    public TMP_Text pocketDestroyedRender;

    public float PocketDestroyed
    {
        get => _pocketDestroyed;
        set
        {
            pocketDestroyedRender.text = value.ToString();
            _pocketDestroyed = value;
        }
    }
}
