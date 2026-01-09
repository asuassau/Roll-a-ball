using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Simplemente rota los pickups alrededor de sus ejes X, Y y Z cada frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
