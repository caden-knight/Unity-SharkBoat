using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float boatSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBoat();
    }

    void MoveBoat()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical) * boatSpeed;

        transform.Translate(movementDirection * Time.deltaTime, Space.World);
    }
}
