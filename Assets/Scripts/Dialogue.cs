using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject Ins;
    // Start is called before the first frame update
    void Awake()
    {
        D1.SetActive(true);

    }
    public void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (D1.active == true && Input.GetMouseButtonDown(0))
        {
            D2.SetActive(true);
            D1.SetActive(false);
        }
        else if (D2.active == true && Input.GetMouseButtonDown(0))
        {
            D3.SetActive(true);
            D2.SetActive(false);
        }
        else if (D3.active == true && Input.GetMouseButtonDown(0))
        {
            D4.SetActive(true);
            D3.SetActive(false);
        }
        else if (D4.active == true && Input.GetMouseButtonDown(0))
        {
            //D2.SetActive(true);
            D4.SetActive(false);
            Ins.SetActive(false);
            Destroy(Ins);
        }
    }
}
