using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Manager mng = new Manager();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.3f, 0f));
    }
}
