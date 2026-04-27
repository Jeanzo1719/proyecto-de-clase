using UnityEngine;

public class CamaraTerceraPersona : MonoBehaviour
{
    public Transform target;

    public float distance = 10.0f;
    public float anguloVertical = 45.0f;
    public float anguloHorizontal = 90.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        // angulo de rotación de la camara
        Quaternion rotation = Quaternion.Euler(anguloVertical, anguloHorizontal, 0);

        // la posición deseada según el objetivo
        Vector3 offset = rotation * Vector3.back * distance;
        Vector3 posicionDeseada = target.position + offset;
        
        transform.position = posicionDeseada;

        //obligando a la caara a mirar al objetivo
        transform.LookAt(target.position);
    }
}
