using UnityEngine;

public class SwapOBJ : MonoBehaviour
{
    public GameObject firstObject;
    public GameObject secondObject;
    public GameObject thirdObject;

    //public GameObject clickedGameObject;
    //public GameObject clickedGameObject2;


    private Vector3 firstObjectPosition;
    private Vector3 secondObjectPosition;
    private Vector3 thirdObjectPosition;

    //private Vector3 clickedObjectPosition;
    //private Vector3 clickedObjectPosition2;

    //int count = 1;
    
    private void Start()
    {

        // �����ʒu��ۑ�����
        firstObjectPosition = firstObject.transform.position;
        secondObjectPosition = secondObject.transform.position;
        thirdObjectPosition = thirdObject.transform.position;

        //clickedObjectPosition = clickedGameObject.transform.position;
        //clickedObjectPosition2 = clickedGameObject2.transform.position;
    }

    private void Update()
    {
        

        // �X�y�[�X�L�[�������ꂽ��A�I�u�W�F�N�g�̈ʒu�����ւ���
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SwapPositions();
        }

    }


    private void SwapPositions()
    {
        // �ʒu�����ւ���
        Vector3 temp = firstObject.transform.position;
        Vector3 temp2 = secondObject.transform.position;
        Vector3 temp3 = thirdObject.transform.position;

        firstObject.transform.position = temp3;
        secondObject.transform.position = temp;
        thirdObject.transform.position = temp2;
        firstObject.transform.position = thirdObject.transform.position;

        // �ʒu�����ւ���
        //Vector3 temp = firstObject.transform.position;
        //firstObject.transform.position = secondObject.transform.position;
        //secondObject.transform.position = temp; 



        // �����ʒu��ۑ�����
        //firstObjectPosition = firstObject.transform.position;
        //secondObjectPosition = secondObject.transform.position;
        //thirdObjectPosition = thirdObject.transform.position;

    }

    // ���Z�b�g�{�^���������ꂽ��A�ʒu�������ʒu�ɖ߂�
    public void ResetPositions()
    {
        firstObject.transform.position = firstObjectPosition;
        secondObject.transform.position = secondObjectPosition;
        thirdObjectPosition = thirdObject.transform.position;
        //clickedGameObject.transform.position = clickedGameObject.transform.position;
        //clickedGameObject2.transform.position = clickedGameObject2.transform.position;
    }
}