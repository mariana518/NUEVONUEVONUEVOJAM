using UnityEngine;

public class Puerta : MonoBehaviour
{
    public string escenaDestino;  //a ke escena va la puerta

    // en qué fases funciona para ver qur puerta se puede abrir y cual no
    public int faseMinima = 0;   
    public int faseMaxima = 99;

    bool jugadorEnPuerta = false;

    void Update()
    {
        if (!jugadorEnPuerta) return;

        //kuando se mete la figura 1 cambia la dinamica  
        KeyCode tecla = KeyCode.P;

        if (Input.GetKeyDown(tecla))
        {
            int fase = GameManager.Instance.fase;

            if (fase >= faseMinima && fase <= faseMaxima)
                GameManager.Instance.CambiarEscena(escenaDestino);
            else
                Debug.Log("La puerta está cerrada");
        }
    }

    // El payaso se paró frente a la puerta
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player")) jugadorEnPuerta = true;
    }

    // El payaso se alejó de la puerta
    void OnTriggerExit2D(Collider2D otro)
    {
        if (otro.CompareTag("Player")) jugadorEnPuerta = false;
    }
}