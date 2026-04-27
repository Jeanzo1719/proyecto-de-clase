using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] public GameObject obstaculo;
    private float startDealy = 1f;
    private float tiempoRepetición = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

        InvokeRepeating("SpawnObstaculo", startDealy, tiempoRepetición);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstaculo()
    {
        if (playerControlScript.gameOver == false)
        {
        Instantiate(obstaculo, spawnPos, obstaculo.transform.rotation);
        }
    }
}
