using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitNubes : MonoBehaviour
{
    [SerializeField] Transform centerOfMass;
    public float orbitalSpeed = 10f;
    private void Update()
    {
        Orbit();
    }
    void Orbit()
    {
        transform.RotateAround(centerOfMass.position, Vector3.up, orbitalSpeed * Time.deltaTime);
    }

}
