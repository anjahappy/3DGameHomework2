using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChildObject : MonoBehaviour
{
    // Start is called before the first frame update
    public 
        void Start()
        {
            GameObject create = GameObject.CreatePrimitive(PrimitiveType.Cube);
            create.name = "Cube 1.1";
            create.transform.position = new Vector3(0, Random.Range(0, 5), 0);
            create.transform.parent = this.transform;
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
