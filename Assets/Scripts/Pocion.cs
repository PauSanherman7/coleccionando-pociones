using UnityEngine;

public class Pocion : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otro)
    {
        
        if (otro.name == "Player")
        {
            // Aumenta el contador global
            ControladorJuego.pociones++;

            // Destruye la poción
            Destroy(gameObject);

            Debug.Log("Pociones: " + ControladorJuego.pociones);

        }
    }
}
