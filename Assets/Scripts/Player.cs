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
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * �O���ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɑO�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = this.transform.forward * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * ���ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɍ������̃x�N�g������
         */
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 move = -this.transform.right * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * �E�ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�ɉE�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 move = this.transform.right * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
        /*
         * ����ɗ͂������邱�Ƃňړ�������
         * Vector3�^�ϐ�move�Ɍ�����̃x�N�g������
         */
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 move = -this.transform.forward * maxspeed;
            this.GetComponent<Rigidbody>().velocity = move;
        }
    }
}
