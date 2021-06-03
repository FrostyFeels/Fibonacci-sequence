using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomColor : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private MeshRenderer myMaterial;
    [SerializeField] private Material[] materials;
    void Start()
    {
        //to give the blocks a seperate and more unique color.
        int i = Random.Range(0, 10);
        
        myMaterial.material.color = materials[i].color;     
    }


}
