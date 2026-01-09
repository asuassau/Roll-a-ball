using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    //Hace referencia al transform del jugador.
    public Transform player;

    // se crae una variable privada para almacenar el componente NavMeshAgent.
    private NavMeshAgent navMeshAgent;

 
    void Start()
    {
        // se almacena el componente NavMeshAgent del enemigo.
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Verifica si la referencia al jugador no es nula.
        if (player != null)
        {
            // Hace que el enemigo se mueva hacia la posición del jugador.
            navMeshAgent.SetDestination(player.position);
        }
    }
}