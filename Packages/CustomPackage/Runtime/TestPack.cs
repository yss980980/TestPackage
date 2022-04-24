using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPack : MonoBehaviour
{
    public static TestPack Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void Hello()
    {
        Debug.Log("你好");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Hello();
        }
    }
}
