using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] private int bumpCount;
    // Start is called before the first frame update
    void Start()
    {
        bumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
        {
            other.gameObject.tag = "Hit";
            bumpCount++;
        }
    }
}
