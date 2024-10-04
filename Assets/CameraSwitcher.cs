using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera[] cameras;
    public int currentCameraIndex;
    void Start()
    {
        cameras = Camera.allCameras;
        for(int i = 0; i < cameras.Length;i++){
            if(i != 2){
                cameras[i].enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            cameras[currentCameraIndex].enabled = false;
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
            cameras[currentCameraIndex].enabled = true;
        }
    }
}
