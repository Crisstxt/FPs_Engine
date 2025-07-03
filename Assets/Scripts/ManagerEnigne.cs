using UnityEngine;

public class ManagerEnigne : MonoBehaviour
{
    public static ManagerEnigne Instance;

    [Header("Personaje Prinicipal")]
    [SerializeField] private GameObject personajePrincipal;

    [Header("Movimiento")]
    [SerializeField] private float velocidadPersonajeCaminar;
    [SerializeField] private float velocidadPersonaCorrer;
    [SerializeField] private float gravedad;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private float estamina;

    [Header("Raton")]
    [SerializeField] private float sensivilidadRaton;
    [SerializeField] private float limiteRotacionVertical = 10.0f;


    private void Awake()
    {
        Instance = this;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //--------------------------
    //------Get.....Set---------
    //--------------------------

    public GameObject PersonajePrincipal
    {
        get { return personajePrincipal; }
        set { personajePrincipal = value; }
    }

    public float VelocidadPersonajeCaminar
    {
        get { return velocidadPersonajeCaminar; }
        set { velocidadPersonajeCaminar = value; }
    }

    public float VelocidadPersonajeCorrer
    {
        get { return velocidadPersonaCorrer; }
        set { velocidadPersonaCorrer = value; }
    }

    public float Gravedad
    {
        get { return gravedad; }
        set { gravedad = value; }
    }

    public float FuerzaSalto
    {
        get { return fuerzaSalto; }
        set { fuerzaSalto = value; }
    }

    public float Estamina
    {
        get { return estamina; }
        set { estamina = value; }
    }

    public float SensivilidadRaton
    {
        get { return sensivilidadRaton; } 
        set { sensivilidadRaton = value; }
    }

    public float LimiteRotacionVertical
    {
        get { return limiteRotacionVertical; }
        set { limiteRotacionVertical = value; }
    }


}
