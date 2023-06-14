using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficController : MonoBehaviour
{
    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;
    [SerializeField] private float speed;
    [SerializeField] private float triggerDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (playerOne.transform.position.z >= triggerDistance || playerTwo.transform.position.z >= triggerDistance)
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
