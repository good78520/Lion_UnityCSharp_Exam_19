using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    public GameObject cube;

    

    private void Start()
    {
        burnDiamond();
    }
    private void burnDiamond()
    {
        for (int i = 1; i < 2; i++)
        {
            Vector3 pos = new Vector3(i + 2.5f, 4, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 1; i < 3; i++)
        {
            Vector3 pos = new Vector3(i +2, 3, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 1; i < 5; i++)
        {
            Vector3 pos = new Vector3(i+1, 2, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }


        for (int i = 1; i < 7; i++)
        {
            Vector3 pos = new Vector3(i, 1, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 0; i < 8; i++)
        {
            Vector3 pos = new Vector3(i,0,0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 1; i < 7; i++)
        {
            Vector3 pos = new Vector3(i, -1, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 1; i < 5; i++)
        {
            Vector3 pos = new Vector3(i + 1, -2, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
        for (int i = 1; i < 3; i++)
        {
            Vector3 pos = new Vector3(i + 2, -3, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }

        for (int i = 1; i < 2; i++)
        {
            Vector3 pos = new Vector3(i + 2.5f, -4, 0);
            Instantiate(cube, pos, Quaternion.identity);
        }
    }


}
