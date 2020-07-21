using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class walk : MonoBehaviour
{

    private void Update()
    {
        gameObject.transform.position += new Vector3(0, 0, 0.5f*Time.deltaTime);
    }


}
