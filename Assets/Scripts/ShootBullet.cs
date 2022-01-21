using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShootBullet : MonoBehaviour 
{
    // �N�[���^�C��
    [SerializeField]
    const float ct = 0.1f;

    // �e�ۏ�������
    [SerializeField]
    float disap;

    // �o�ߎ���
    [SerializeField]
    float time;

    // �e��
    [SerializeField]
    public GameObject bullet;
    // �e��
    public float speed = 2000f;

    // �e�ې������̍��W
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
        // �}�E�X�����N���b�N�����u��
        if (Input.GetMouseButtonDown(0))
        {
            time = 0f;
            shoot();
        }
        // �}�E�X���{�^�����z�[���h�����ꍇ
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
