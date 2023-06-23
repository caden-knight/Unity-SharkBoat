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
        float vertical = Input.GetAxis("Vertical") * boatSpeed;
        float horizontal = Input.GetAxis("Horizontal") * boatSpeed;

        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;

        // inverted the two axis' and the speed because of the nature of the model I used
        transform.Translate(Vector3.right * -vertical);
        transform.Translate(Vector3.forward * horizontal);
    }
}
