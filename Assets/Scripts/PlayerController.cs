using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
