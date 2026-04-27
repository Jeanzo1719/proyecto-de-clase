using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float speed = 10f;
    [SerializeField] private Rigidbody rb;

    public bool isOnGround = true;
    public bool gameOver = false;
    //private Vector3 inputMovement;

    private Animator playerAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAnim.SetFloat("Speed_f", 1);    
 
         if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up* speed, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        isOnGround = true;

        if (collision.gameObject.CompareTag("obstaculo"))
        {
            gameOver = true;
            Debug.Log("game Over");
        }
    }


}
