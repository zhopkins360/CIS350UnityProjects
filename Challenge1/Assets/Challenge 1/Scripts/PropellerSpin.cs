/*
*Zackary Hopkins
*Challenge1
*makes the propeller on the plane spin
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinFloat;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinFloat, Space.Self);
    }
}
