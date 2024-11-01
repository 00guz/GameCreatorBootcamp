using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField]
    public List<Camera> cameras = new List<Camera>();
    void Start()
    {
       ActiveCamera(cameras[0]);
    }

    void Update()
    {
        for (int i = 0; i < cameras.Count; i++){
            if (Input.GetKeyDown((i+1).ToString())){
                ActiveCamera(cameras[i]);
            }
        }
       
    }

    void ActiveCamera(Camera activeCamera)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            if (cameras[i] != activeCamera)
            {
                cameras[i].gameObject.SetActive(false);
            }
        }
        activeCamera.gameObject.SetActive(true);
    }
}
