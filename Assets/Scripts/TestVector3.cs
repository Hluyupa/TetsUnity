using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVector3 : MonoBehaviour
{
    public Vector3 position;
    public float Speed = 5.0f;
    public GameObject FollowingGameObject;

    private void Awake()
    {
        position = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var a = FollowingGameObject.transform.position - transform.position;
        //Debug.Log(a.ToString());
        transform.position += a * Speed;
    }
}
