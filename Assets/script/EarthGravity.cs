using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravity : MonoBehaviour
{
    // La nouvelle valeur de gravit� que tu veux d�finir
    public Vector3 nouvelleGravite = new Vector3(0f, -20f, 0f);

    void Start()
    {
        // Changer la gravit�
        Physics.gravity = nouvelleGravite;
    }
}
