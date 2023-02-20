using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    /// <summary>
    /// GameOverAreaにこのスクリプトがついているオブジェクトが触れたら
    /// 触れたオブジェクトをすぐに消す
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GameOverArea") //他のオブジェクトがGameOverAreaに触れたら
        {
            //Destroy
            Destroy(this.gameObject);
        }
    }
}
