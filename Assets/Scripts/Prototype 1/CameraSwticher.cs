using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwticher : MonoBehaviour
{
    [SerializeField] private GameObject firstPersonCamera;
    [SerializeField] private GameObject thirdPersonCamera;
    private bool isThirdPersonMode = true;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.SetActive(false);
        thirdPersonCamera.SetActive(true);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isThirdPersonMode = !isThirdPersonMode;

            if (isThirdPersonMode)
            {
                firstPersonCamera.SetActive(false);
                thirdPersonCamera.SetActive(true);
            }
            else
            {
                firstPersonCamera.SetActive(true);
                thirdPersonCamera.SetActive(false);
            }
        }

        thirdPersonCamera.transform.eulerAngles = Vector3.right * 18.111f;
    }
}
