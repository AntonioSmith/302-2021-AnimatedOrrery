using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public string population;
    public Transform target;

    [Range(-10, 10)] public float revolutionSpeed = 1; // Allows a range of speed for the planets between -10 and 10

    [Range(-100, 100)] public float Xradius; 
    //[Range(-100, 100)] public float Yradius; // Separated radius into each axes so it's editable in Inspector
    [Range(-100, 100)] public float Zradius;
    public float age;

    void Update()
    {
        RevolveAround();
    }   

    public void RevolveAround()
    {
        age += Time.deltaTime;

        /// <summary> 
        /// A T T E M P T  1 
        /// Vector3 offset = new Vector3();
        /// offset.x = revolutionSpeed * (Mathf.Sin(age) * radius);
        /// offset.y = revolutionSpeed * (Mathf.Cos(age) * radius); // no need for revolution on y-axis right now
        /// offset.z = revolutionSpeed * (Mathf.Tan(age) * radius);
        /// 
        /// transform.position = target.position + offset;
        /// transform.position = new Vector2(offset.x, offset.z) * target.position;
        /// </summary>

        /// <summary>
        /// A T T E M P T  2
        /// Vector3 offset = new Vector3();
        /// offset.x = Mathf.Sin(age) * 200 + radius / 2;
        /// offset.y = Mathf.Cos(age) * 200 + radius / 2;
        /// offset.z = Mathf.Tan(age) * 200 + radius / 2
        ///
        /// transform.position = target.position + offset;
        /// </summary>

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * Xradius;
        //offset.y = Mathf.Sin(age) * Yradius;
        offset.z = Mathf.Cos(age) * Zradius;

        transform.position = target.position + offset;
    }
}
