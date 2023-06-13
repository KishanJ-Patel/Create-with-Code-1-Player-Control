using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    // Private variables
    [SerializeField] private GameObject player;
    private Vector3 thirdPersonOffset = new Vector3(0, 5, -7);
    private Vector3 firstPersonOffset = new Vector3(0, 2.32f, -0.04f);
    private float thirdPersonRotationX = 18.111f;
    private bool isThirdPersonMode = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        if (Input.GetKeyDown(KeyCode.V)) isThirdPersonMode = !isThirdPersonMode;

        // Offset the camera behind/in front the player by adding to the player's position
        if (isThirdPersonMode)
        {
            transform.position = player.transform.position + thirdPersonOffset;
            transform.eulerAngles = Vector3.right * thirdPersonRotationX;
        }
        else
        {
            transform.position = player.transform.position + firstPersonOffset;
            transform.eulerAngles = player.transform.eulerAngles;
        }
    }
}
