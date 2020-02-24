using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int[] array = {10,1,2,3,4};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[4-i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}