using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayerController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    #endregion

    #region public method

    #endregion

    #region private method

    #endregion

    [SerializeField] float moveForce = 30f; // �f�t�H���ƒx���̂ŌW����������

    // private fileds

    // ���rb�R���|�錾(private: inspector�ɂ͕\������Ȃ�)
    Rigidbody rb; // ���ɐ錾��start���ɏ����ƁAstart�̃��[�J���ϐ��ɂȂ��Ă��܂�

    // Start is called once 
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); // �����I�u�W�F�N�g�AgameObject(Player)��Rigidbody����
    }

    // Update is called once per frame
    void Update()
    {
        // ���t���[�����͎�t
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // �͂������ē�����
        rb.AddForce(moveForce * horizontal, 0, moveForce * vertical);

        
    }
    
}
