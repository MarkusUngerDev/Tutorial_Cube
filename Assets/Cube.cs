using System;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float rotationSpeed = 100f;
    
    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV();
    }

    private void Update()
    {
        transform.Rotate(Vector3.one, rotationSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        ChangeColor();
    }
}
