using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private GameObject ptefabPlayer;


    private void Start()
    {
        Instantiate(ptefabPlayer);
    }
}
