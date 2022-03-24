using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Spins the propeller
 * 03/24/22
 */

public class PropellerSpinner : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y - 1, transform.rotation.z) * Time.deltaTime * speed);
    }
}
