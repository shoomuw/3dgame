using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShootBullet : MonoBehaviour 
{
    // クールタイム
    const float ct = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
    void shoot() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            float time = 0f;
            if (time > ct) 
            { 
                Debug.Log("shoot");
                time = 0f;
            }
            time += Time.deltaTime;
        }
    }
}
