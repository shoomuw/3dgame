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
        this.transform.rotation = Quaternion.AngleAxis(0f, spawn);
    }

    // Update is called once per frame
    void Update()
    {
        bool flag = false;
        Vector3 move = Vector3.zero;
        /*
         * 前方に力を加えることで移動させる
         * Vector3型変数moveに前方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.W))
        {
            flag = true;
            move += this.transform.forward * maxspeed;
        }
        /*
         * 左に力を加えることで移動させる
         * Vector3型変数moveに左方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.A))
        {
            flag = true;
            move += -this.transform.right * maxspeed;
        }
        /*
         * 右に力を加えることで移動させる
         * Vector3型変数moveに右方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.D))
        {
            flag = true;
            move += this.transform.right * maxspeed;
        }
        /*
         * 後方に力を加えることで移動させる
         * Vector3型変数moveに後方向のベクトルを代入
         */
        if (Input.GetKey(KeyCode.S))
        {
            flag = true;
            move += -this.transform.forward * maxspeed;
        }
        /*
         * フラグがfalseの場合、速度を0にする
         */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move += this.transform.up * maxspeed;
        }
        if (!flag)
        {
            move = Vector3.zero;
        }

        this.GetComponent<Rigidbody>().velocity = move;

    }
}
