using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCamera : MonoBehaviour
{
    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        if (Input.GetKeyDown(KeyCode.Alpha1)) {   
            foreach(Camera cam in cameras) {
                if (i == 0)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            foreach (Camera cam in cameras) {
                if (i == 1)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            foreach (Camera cam in cameras) {
                if (i == 2)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
        else if (Input.GetKeyDown("4")) {
            foreach (Camera cam in cameras) {
                if (i == 3)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
        else if (Input.GetKeyDown("5")) {
            foreach (Camera cam in cameras) {
                if (i == 4)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
        else if (Input.GetKeyDown("6")) {
            foreach (Camera cam in cameras) {
                if (i == 5)
                    cam.enabled = true;
                else
                    cam.enabled = false;
                i++;
            }
        }
    }
}
