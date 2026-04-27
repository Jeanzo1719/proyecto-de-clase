using UnityEngine;

public class MovVBack : MonoBehaviour
{
    private Vector3 posInicial;
    private float tamañoRepeticion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posInicial = transform.position;
        tamañoRepeticion = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < posInicial.x - tamañoRepeticion)
        {
            transform.position = posInicial;
        }
    }
}
