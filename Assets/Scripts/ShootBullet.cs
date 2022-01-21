using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShootBullet : MonoBehaviour 
{
    // クールタイム
    [SerializeField]
    const float ct = 0.1f;

    // 弾丸消失時間
    [SerializeField]
    float disap;

    // 経過時間
    [SerializeField]
    float time;

    // 弾丸
    [SerializeField]
    public GameObject bullet;
    // 弾速
    public float speed = 2000f;

    // 弾丸生成時の座標
    public Transform nozzle;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        disap = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスを左クリックした瞬間
        if (Input.GetMouseButtonDown(0))
        {
            time = 0f;
            shoot();
        }
        // マウス左ボタンをホールドした場合
        if (Input.GetMouseButton(0))
        {
            if (time > ct)
            {
                Debug.Log("shoot");
                time = 0f;
                shoot();
            }
            time += Time.deltaTime;
        }
    }

    void shoot()
    {
        GameObject bullets = Instantiate(bullet) as GameObject;

        Destroy(bullets, 25f);

        Vector3 force = this.gameObject.transform.forward * speed;

        bullets.GetComponent<Rigidbody>().AddForce(force);

        bullets.transform.position = nozzle.position;
    }
}
