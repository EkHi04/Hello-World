using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour

{
    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        createCubeandSetParent();
    }

    private void createCubeandSetParent()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        checkScale();
        checkRotation();
    }
    private void checkMovement()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down *speed ;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;
        }
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale += Vector3.right * speed;
        }
    }

    private void checkRotation()
    {
        this.transform.rotation *= Quaternion.Euler(0, 1*speed, 0);
    }

}
