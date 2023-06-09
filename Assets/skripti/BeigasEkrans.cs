﻿using UnityEngine;
using UnityEngine.UI;

public class BeigasEkrans : MonoBehaviour
{
    public GameObject beiguEkrans;
    public GameObject TextaLaiks;
    public GameObject Zvaigzne1;
    public GameObject Zvaigzne2;
    public GameObject Zvaigzne3;

	public GameObject EmptyZvaigzne1;
	public GameObject EmptyZvaigzne2;
	public GameObject EmptyZvaigzne3;

    private bool Taimers = true;
	private float TaimeraStarts;
    public float TaimeraBeigas;

    private void Start()
    {
        Taimers = true;
        SaktTimer();
    }

    private void Update()
    {
        if (Taimers)
        {
            if (NomesanasVieta.rezultats < 12 && !beiguEkrans.activeSelf)
            {
                TaimeraBeigas = Time.time;
            }
            else
            {
                Taimers = false;
                BeigtTimer();
            }
        }

    }

    private void SaktTimer()
    {
        TaimeraStarts = Time.time;
        Debug.Log("Laiks sakas!");
    }

    private void BeigtTimer()
    {
        TaimeraBeigas = Time.time;
        float duration = TaimeraBeigas - TaimeraStarts;
		if(Input.GetKey(KeyCode.T)){
			TaimeraBeigas= TaimeraBeigas+10f;
		}

        Debug.Log("Laiks Beidzās! Laiks: " + duration.ToString("F2") + " Sekundes");
        TextaLaiks.GetComponent<Text>().text = "Laiks: " + duration.ToString("F2") + " S";

       if (duration >= 180f) 
    {
        Zvaigzne1.SetActive(false);
        Zvaigzne2.SetActive(false);
        Zvaigzne3.SetActive(false);
		EmptyZvaigzne1.SetActive(true);
		EmptyZvaigzne2.SetActive(true);
		EmptyZvaigzne3.SetActive(true);
    }
    else if (duration >= 120f) 
    {
        Zvaigzne1.SetActive(true);
        Zvaigzne2.SetActive(false);
        Zvaigzne3.SetActive(false);
		EmptyZvaigzne2.SetActive(true);
		EmptyZvaigzne3.SetActive(true);
    }
    else if (duration >= 60f) 
    {
        Zvaigzne1.SetActive(true);
        Zvaigzne2.SetActive(true);
        Zvaigzne3.SetActive(false);
		EmptyZvaigzne3.SetActive(true);
    }
    else
    {
        Zvaigzne1.SetActive(true);
        Zvaigzne2.SetActive(true);
        Zvaigzne3.SetActive(true);
    }
    }
}
