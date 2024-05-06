using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravity : MonoBehaviour
{
    // La nouvelle valeur de gravité que tu veux définir
    public Vector3 nouvelleGravite = new Vector3(0f, -20f, 0f);

    void Start()
    {
        // Changer la gravité
        Physics.gravity = nouvelleGravite;
    }
}
