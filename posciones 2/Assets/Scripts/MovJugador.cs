using UnityEngine;
using UnityEngine.InputSystem;

public class MovJugador : MonoBehaviour
{
    public float velocidad = 5;
    private Rigidbody2D rb;
    private Vector2 entrada;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        rb.linearVelocity = entrada * velocidad;
        
    }

    public void Moverse(InputAction.CallbackContext contexto)
    {
        entrada = contexto.ReadValue<Vector2>();
    }
}
