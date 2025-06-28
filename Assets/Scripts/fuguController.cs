using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuguController : MonoBehaviour
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


    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 衝突時に呼び出し
    void OnTriggerEnter() // 相手情報は要らない
    {
        Destroy(gameObject); // 重なったらフグ(gameObject)を削除
    }

}
