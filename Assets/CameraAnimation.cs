using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    public GameObject SteeringView, BehindView;

    void Start()
    {
        // Start invoking the CameraSwitching method with a delay of 3 seconds and repeat every 10 seconds.
        InvokeRepeating("CameraSwitching", 3f, 7f);
    }

    void CameraSwitching()
    {
        // Activate both cameras
        SteeringView.SetActive(true);
        BehindView.SetActive(true);

        // Deactivate the behind camera after 10 seconds
        Invoke("DeactivateBehindCamera", 10f);
    }

    void DeactivateBehindCamera()
    {
        // Deactivate the behind camera
        BehindView.SetActive(false);
    }

}
