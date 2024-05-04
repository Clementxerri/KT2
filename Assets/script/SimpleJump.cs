using UnityEngine;

public class SimpleJump : MonoBehaviour
{
    public float jumpForce = 5f; // La force du saut

    private Rigidbody rb;
    private bool isGrounded; // Pour v�rifier si le joueur est au sol

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        // V�rifie si le joueur entre en contact avec une surface consid�r�e comme solide
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Si le joueur quitte la surface consid�r�e comme solide, il n'est plus au sol
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void Update()
    {
        // Si le joueur est au sol et appuie sur la touche de saut
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            // Applique une force vers le haut pour simuler le saut
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
