using UnityEngine;

public class Piezas : MonoBehaviour
{
    public int numero = 1;   
    void Start()
    {
        // Si la pieza ya se metió al cubo o la traes pueskee no aparezca
        var gm = GameManager.Instance;
        if (gm.fase >= numero || gm.piezaEnMano) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            GameManager.Instance.piezaEnMano = true; 
            Destroy(gameObject); //desaparece del piso
        }
    }
}