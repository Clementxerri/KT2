using UnityEngine;

public class SimpleJump : MonoBehaviour
{
    public float hauteurSaut = 8f; // Hauteur du saut
    public KeyCode toucheSaut = KeyCode.Space; // Touche pour sauter

    private bool auSol = true; // Vérifie si le joueur est au sol

    void Update()
    {
        // Si le joueur est au sol et appuie sur la touche de saut
        if (Input.GetKeyDown(KeyCode.Space) && auSol)
        {
            print("saut");
            // Ajouter une force vers le haut pour simuler le saut
            GetComponent<Rigidbody>().velocity = new Vector3(0, hauteurSaut, 0);
            auSol = false; // Le joueur n'est plus au sol
        }
    }

    // Vérifier si le joueur touche le sol
    private void OnCollisionEnter(Collision collision)
    {
        print("au sol");
        auSol = true; // Le joueur est au sol
    }
}
