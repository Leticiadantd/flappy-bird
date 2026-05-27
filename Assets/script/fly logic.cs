using UnityEngine;

public class flylogic : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    void Start()
    {
        Debug.Log("SCRIPT RODANDO NO BIRD");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}