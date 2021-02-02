using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	public float rotX;
	public float rotY;
	public float rotZ;
    void Update()
    {
        transform.Rotate(rotX*Time.deltaTime, rotY*Time.deltaTime, rotZ*Time.deltaTime);
    }
}
