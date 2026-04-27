using UnityEngine;

public class ObstaculosMov : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    [SerializeField] private float limiteIzq = -20f;

    private Movement playerControlScript;

    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");

        if (playerObject != null)
        {
            playerControlScript = playerObject.GetComponent<Movement>();
        }
        else
        {
            Debug.LogWarning("NO SE ENCONTRO OBJETO CON EL TAG BUSCADO");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < limiteIzq && gameObject.CompareTag("obstaculo"))
        {
            Destroy(gameObject);
        }

    }
}
