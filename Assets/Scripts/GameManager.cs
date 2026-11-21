using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int fase = 0;   //ESTA es para ke el juego vaya sabiendo en ke fase va dependiendo de cuantas piezas ya hayas agarrado
    public bool piezaEnMano = false;  //si es true es ke traemos una pieza ke agarramos y pues podemos meterla en el kuvo
                                      // ---- Teclas según la fase ----
                                      // En la fase 1 (después de meter la primera pieza) cambian a J B N M
    public bool ControlesCambiados => fase == 1;

    public KeyCode TeclaArriba => ControlesCambiados ? KeyCode.J : KeyCode.W;
    public KeyCode TeclaIzquierda => ControlesCambiados ? KeyCode.B : KeyCode.A;
    public KeyCode TeclaAbajo => ControlesCambiados ? KeyCode.N : KeyCode.S;
    public KeyCode TeclaDerecha => ControlesCambiados ? KeyCode.M : KeyCode.D;

    void Awake()
    {
        // por si ya existe un gamemanager en la escena ni crea uno nuevo
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // no se borra al cambiar de escena
    }

    
    //esto se usara para las puertas de los cuartos 
    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}