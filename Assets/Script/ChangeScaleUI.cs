using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ChangeScaleUI : MonoBehaviour
{
    public GameObject panel;
    private bool isDafaultScale;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.DOScale(new Vector3(2f, 2f, 2f), 2f).SetLoops(3,LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(isDafaultScale)
            {
                panel.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
                isDafaultScale = false;
            }
            if(!isDafaultScale)
            {
                panel.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
                isDafaultScale = false;
            }
        }
    }
}
