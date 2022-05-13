using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    faceDetector FaceDetector;
    float speed = 5f;
    float lastY = 0;
    void Start()
    {
        FaceDetector = (faceDetector)FindObjectOfType(typeof(faceDetector));
    }

    // Update is called once per frame
    public void Update()

    {

        float step = speed * Time.deltaTime;




        float norm = Mathf.Clamp(FaceDetector.faceY - lastY, -1, 1);

        //below transform code is in one line

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + norm, transform.position.z), step);


        //below line was additional added, then the character starts moving
        lastY = FaceDetector.faceY;





    }
}
    