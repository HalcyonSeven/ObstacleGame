using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDropper : MonoBehaviour
{
    Rigidbody obstacleRb;
    MeshRenderer obstacleMR;
    [SerializeField] private float dropTimer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        obstacleMR = GetComponent<MeshRenderer>();
        obstacleRb = GetComponent<Rigidbody>();

        obstacleRb.useGravity = false;
        obstacleMR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTimer)
        {
            obstacleMR.enabled = true;
            obstacleRb.useGravity = true;
            Debug.Log("Drop");
        }
    }
}
