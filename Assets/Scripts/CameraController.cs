using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
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

    // serialice fileds
    [SerializeField] Transform player_trans; // inspector����player���h���b�v

    // Start is called once 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPlayerPosition = player_trans.position; // ��ƂȂ�plyer�̈ʒu
        Vector3 higherPlayerPosition = new Vector3(currentPlayerPosition.x, currentPlayerPosition.y + 14, currentPlayerPosition.z);

        gameObject.GetComponent<Transform>().position = higherPlayerPosition;  // trans��higher��
    }
    
}
