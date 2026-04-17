using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMino : MonoBehaviour
{
    public GameObject[] Minos;
    // Start is called before the first frame update
    void Start()
    {
        NewMino();
    }

    public void NewMino() 
    {
        int index = 0;// ランダム生成するコードをここに追加
        Instantiate(Minos[index], transform.position, Quaternion.identity);
    }
}

//         int index = Random.Range(0, Minos.Length);
