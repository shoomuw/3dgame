using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // HP

    // �������X�|�[���n
    Vector3 spawn = new Vector3(5f, 0.5f, 5f);

    // �ő呬�x
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
         * �O���ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɑO�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.W))
        {
            flag = true;
            move += this.transform.forward * maxspeed;
        }
        /*
         * ���ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɍ������̃x�N�g������
         */
        if (Input.GetKey(KeyCode.A))
        {
            flag = true;
            move += -this.transform.right * maxspeed;
        }
        /*
         * �E�ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɉE�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.D))
        {
            flag = true;
            move += this.transform.right * maxspeed;
        }
        /*
         * ����ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�Ɍ�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.S))
        {
            flag = true;
            move += -this.transform.forward * maxspeed;
        }
        /*
         * �t���O��false�̏ꍇ�A���x��0�ɂ���
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
