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
        // ランダムに生成するコードは？
        Instantiate(Minos[0], transform.position, Quaternion.identity);
    }
}