using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // se crea una variable para el rigidbody
    private Rigidbody rb;

    // Fuerza de salto
    public float jumpForce = 5f;
    //referencia para saber si está en el suelo
    private bool isGrounded = true;

    // contador de pickups
    private int count;


    //movimiento en x y en y
    private float movementX;
    private float movementY;

    // velocidad de movimiento
    public float speed = 0;

    // tiempo del nivel
    public float levelTime;
    // tiempo restante
    private float timeLeft;
    // estado del juego
    private bool gameRunning = true;




    // variable para el texto del contador y del tiempo
    public TextMeshProUGUI countText;
    public TextMeshProUGUI timeText;


    // referencia al game manager

    public GameManager gameManager;


   
    void Start()
    {
        //llama al start del game manager pero solo presenta Debug.Log
        gameManager.StartGame();
        //asocia el rigidbody del player a la variable rb
        rb = GetComponent<Rigidbody>();

        // inicializa el contador de pickups a 0
        count = 0;

        // actualiza el texto del contador para cargar el valor inicial 0
        SetCountText();

        // inicializa el tiempo restante
        timeLeft = levelTime;

        // actualiza el texto del tiempo restante
        UpdateTimeText();

    }


    // el metodo update se usa para el tiempo
    void Update()
    {

        // si el juego no está corriendo, no hace nada
        if (!gameRunning) return;

        // resta el tiempo transcurrido al tiempo restante
        timeLeft -= Time.deltaTime;

        // si el tiempo se acaba, llama al metodo de fallo del game manager para mostrar que no se ha superado el nivel  y detiene el juego
        if (timeLeft <= 0f)
        {
            timeLeft = 0f;
            gameRunning = false;
            gameManager.FailLevel();
        }
        // actualiza el texto del tiempo restante
        UpdateTimeText();
    }


    // este metodo se llama cuando se recibe input de movimiento y recoge el valor del input
    void OnMove(InputValue movementValue)
    {
      
        Vector2 movementVector = movementValue.Get<Vector2>();

       
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    //marca el movimiento fisico del player
    private void FixedUpdate()
    {
        //hacer que el player se mueva segun el input recibido
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //aplica una fuerza al rigidbody del player en la direccion del movimiento multiplicada por la velocidad
        rb.AddForce(movement * speed);
    }


    // este metodo se llama cuando el player colisiona con los pickups
    void OnTriggerEnter(Collider other)
    {
        // comprueba si el objeto con el que ha colisionado tiene la etiqueta "PickUp"
        if (other.gameObject.CompareTag("PickUp"))
        {
            // desactiva el objeto "PickUp" para simular que ha sido recogido
            other.gameObject.SetActive(false);

            // incrementa el contador de pickups recogidos
            count = count + 1;

            // actualiza el texto del contador para reflejar el nuevo valor
            SetCountText();
        }
    }

    // actualiza el texto del contador y comprueba la condicion de victoria
    void SetCountText()
    {
        // Actualiza el texto del contador con el valor actual
        countText.text = "Count: " + count.ToString();

        // Si se han recogido 9 pickups, el jugador gana
        if (count >= 9)
        {
            gameRunning = false;

            gameManager.CompleteLevel();

            // Elimina al enemigo del escenario
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    // Este metodo se llama cuando el player colisiona con el suelo o con un enemigo

    private void OnCollisionEnter(Collision collision)
    {
        // si colisiona con el suelo, marca que está en el suelo

        if (collision.gameObject.CompareTag("Ground"))
           isGrounded = true;

        // si colisiona con un enemigo, detiene el juego y llama al metodo de fallo del game manager
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameRunning = false;
            gameObject.SetActive(false);
            gameManager.FailLevel();
               

        }

    }

    // este metodo se llama cuando se recibe input de salto
    void OnJump()
    {

        // si el juego no está corriendo o no está en el suelo, no hace nada
        if (!gameRunning) return;
        if (!isGrounded) return;

        // aplica una fuerza hacia arriba al rigidbody del player para simular el salto
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        // marca que no está en el suelo para evitar saltos dobles
        isGrounded = false;


    }
    // este metodo se llama cuando el player deja de colisionar con el suelo

    private void OnCollisionExit(Collision collision)
    {
        // si deja de colisionar con el suelo, marca que no está en el suelo
        if (collision.gameObject.CompareTag("Ground"))
        
            isGrounded = false;
        
    }

    // actualiza el texto del tiempo restante
    void UpdateTimeText()
    {
        timeText.text = "Time Left: " + Mathf.CeilToInt(timeLeft).ToString();

    }


}