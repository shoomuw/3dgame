using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // HP

    // 初期リスポーン地
    Vector3 spawn = new Vector3(5f, 0.5f, 5f);

    // 最大速度
    float maxspeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = spawn;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 前方に力を加えることで移動させる
         * Vector3型変数moveに前方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = this.transform.forward * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * 左に力を加えることで移動させる
         * Vector3型変数moveに左方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 move = -this.transform.right * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * 右に力を加えることで移動させる
         * Vector3型変数moveに右方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 move = this.transform.right * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * 後方に力を加えることで移動させる
         * Vector3型変数moveに後方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = -this.transform.forward * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
    }
}
