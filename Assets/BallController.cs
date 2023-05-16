using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallController : MonoBehaviour
{
    [SerializeField] CinemachineFreeLook look;
    private void Update() {
        look.enabled = Input.GetMouseButton(0);
    }
}
