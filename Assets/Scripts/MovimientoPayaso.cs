using UnityEngine;

public class MovimientoPayaso : MonoBehaviour
{

    public float velocidad = 5f;

    void Start()
    {

    }


    void Update()
    {
        float velocidadH = Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidad;
        float velocidadV = Input.GetAxisRaw("Vertical") * Time.deltaTime * velocidad;

        Vector3 posición= transform.position;
        transform.position= new Vector3(velocidadH + posición.x, velocidadV + posición.y, posición.z);

    }
}
