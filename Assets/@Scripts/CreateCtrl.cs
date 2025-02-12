using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateCtrl : MonoBehaviour
{
    public float yp;
    public float speed;

    [SerializeField] private GameObject Pipe;
    [SerializeField] private GameObject Coin;

    void Start()
    {
        StartCoroutine(CreateRoutine());
    }


    void Create()
    {
        // 뒤집힌 파이프 y 포지션
        float flip_yp = yp + 9.0f;
        // 코인 y 포지션
        float coin_yp = yp + 4.5f;

        // 파이프 시작 위치
        Vector3 pipe = new Vector3(5, yp, 0);
        // 뒤집힌 파이프 시작 위치
        Vector3 flip_pipe = new Vector3(5, flip_yp, 0);
        // 코인 시작 위치
        Vector3 coin = new Vector3(5, coin_yp, 0);

        // 두 파이프 랜덤 생성
        Instantiate(Pipe, pipe, Quaternion.identity);
        Instantiate(Pipe, flip_pipe, Quaternion.Euler(180, 0, 0));
        // 코인 랜덤 생성
        Instantiate(Coin, coin, Quaternion.identity);
    }

    IEnumerator CreateRoutine()
    {
        while (true)
        {
            yp = Random.Range(-2, -7);
            Create();
            yield return new WaitForSeconds(5);
        }
    }
}
