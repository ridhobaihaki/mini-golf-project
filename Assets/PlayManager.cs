using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;
    
    bool isBallOutside;
    Vector3 lastBallPosition;
    private void Update() {

        if(ballController.IsMove() && isBallOutside == false)
        {
            lastBallPosition = ballController.transform.position;
        }

        var inputActive = Input.GetMouseButton(0) 
            && ballController.IsMove() == false 
            && ballController.ShootingMode == false
            && isBallOutside == false;

        camController.SetInputActive(inputActive);
    }

    public void OnBallOutside()
    {
        isBallOutside = true;
        Invoke("MoveBallLastPosition", 1);
    }

    public void MoveBallLastPosition()
    {
        ballController.transform.position = lastBallPosition;
        isBallOutside = false;
    }
}
