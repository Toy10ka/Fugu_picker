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

    [SerializeField] float moveForce = 30f; // デフォだと遅いので係数をかける

    // private fileds

    // 空のrbコンポ宣言(private: inspectorには表示されない)
    Rigidbody rb; // 仮に宣言をstart内に書くと、startのローカル変数になってしまう

    // Start is called once 
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>(); // 同じオブジェクト、gameObject(Player)のRigidbodyを代入
    }

    // Update is called once per frame
    void Update()
    {
        // 毎フレーム入力受付
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 力を加えて動かす
        rb.AddForce(moveForce * horizontal, 0, moveForce * vertical);

        
    }
    
}
