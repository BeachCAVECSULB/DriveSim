using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjustment : MonoBehaviour
{

    private int speedUp = -1;


    // Update is called once per frame
    void Update()
    {
        if (speedUp == -1)
        {
            if (Input.GetButtonDown("MoveCamera Y (Keyboard)"))
            {
                if (Input.GetAxisRaw("MoveCamera Y (Keyboard)") > 0)
                    CameraUp(0.2f);
                else if (Input.GetAxisRaw("MoveCamera Y (Keyboard)") < 0)
                    CameraDown(0.2f);

                speedUp = 0;
            }
        }
        else if (speedUp == 0)
        {
            if (Input.GetButton("MoveCamera Y (Keyboard)"))
                speedUp = 1;
            else if (Input.GetButtonUp("MoveCamera Y (Keyboard)"))
                speedUp = -1;
            else
                speedUp = -1;

        }

        if (speedUp == 1)
        {
            if (Input.GetButtonUp("MoveCamera Y (Keyboard)"))
                speedUp = -1;
            else if (Input.GetAxisRaw("MoveCamera Y (Keyboard)") > 0)
                CameraUp(0.5f);
            else if (Input.GetAxisRaw("MoveCamera Y (Keyboard)") < 0)
                CameraDown(0.5f);
            else
                speedUp = -1;
        }
    }

    public void CameraUp(float m)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + (m * Time.deltaTime), transform.position.z);
    }

    public void CameraDown(float m)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (m * Time.deltaTime), transform.position.z);
    }
}
