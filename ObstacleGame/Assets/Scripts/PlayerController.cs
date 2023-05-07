using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // translates position of player in game world
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(horizontalInput, 0, verticalInput);
    }
}
