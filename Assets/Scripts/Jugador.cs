using UnityEngine;

public class Jugador : MonoBehaviour
{
    private float sensibilidadRaton;
    private float limiteRotacionVertical;
    private Vector2 velocidadRotacion;
    private float suavisado = 1f;
    private CharacterController controlador;
    private Vector3 velocidadJugador;


    void Start()
    {
        sensibilidadRaton = ManagerEnigne.Instance.SensivilidadRaton;
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        ControlMov();
        ControlMouse();

    }

    void ControlMov()
    {
        MoverJugador();
    }

    void MoverJugador()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");
        Vector3 movimiento = transform.right * movimientoX + transform.forward * movimientoZ;
        controlador.Move(movimiento);

        if (controlador.isGrounded && velocidadJugador.y < 0) velocidadJugador.y = 0;
        velocidadJugador.y += ManagerEnigne.Instance.Gravedad * Time.deltaTime;
        controlador.Move(velocidadJugador * Time.deltaTime); 

        if(Input.GetKeyDown(KeyCode.Space) && controlador.isGrounded)
        {
            Saltar();
        }
    }

    void Saltar()
    {
        velocidadJugador.y = Mathf.Sqrt(ManagerEnigne.Instance.FuerzaSalto * -2f * ManagerEnigne.Instance.Gravedad);   
    }

    void ControlMouse()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        velocidadRotacion.x = Mathf.Lerp(velocidadRotacion.x, velocidadRotacion.x + mouseDelta.x, suavisado * Time.deltaTime);
        velocidadRotacion.y = Mathf.Lerp(velocidadRotacion.y, velocidadRotacion.y + mouseDelta.y, suavisado * Time.deltaTime);

        limiteRotacionVertical = ManagerEnigne.Instance.LimiteRotacionVertical;

    }

}
