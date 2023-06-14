using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Private variables
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 posOffset;
    [SerializeField] private Vector3 rotOffset; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {   
        transform.localPosition = player.transform.localPosition + posOffset;
        transform.transform.localEulerAngles = rotOffset;
    }
}
