using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    public Rigidbody[] rbs;
    public float radius = 1;
    void Start()
    {
        rbs = FindObjectsOfType<Rigidbody>();
    }

    private void OnMouseDown()
    {
        foreach (Rigidbody rb in rbs)
        {
            rb.AddForce((rb.position - transform.position) * 25 , ForceMode.Impulse);
        }
    }
}
