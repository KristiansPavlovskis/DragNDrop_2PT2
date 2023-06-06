using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {

	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	private CanvasGroup kanvasGrupa;
	public GameObject beiguEkrans;
	public static int rezultats=0;

	public void OnDrop(PointerEventData eventData){
		
		if (eventData.pointerDrag != null) {
			if (eventData.pointerDrag.tag.Equals (tag)) {
				vietasZRot = GetComponent<RectTransform> ().transform.eulerAngles.z;
				velkObjZRot= eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs (velkObjZRot-vietasZRot);
				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform> ().localScale;
				vietasIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (velkObjIzm.x - vietasIzm.x);
				yIzmeruStarp = Mathf.Abs (velkObjIzm.y - vietasIzm.y);

				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >=354 && rotacijasStarpiba<=360) ) && xIzmeruStarp<= 0.1f && yIzmeruStarp <=0.1f) {
					objektuSkripts.vaiIstajaVieta = true;
				
					eventData.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (eventData.pointerDrag.tag) {
					case"atkritumi":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [1]);
				
						break;
					case"medicina":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [2]);
					
						break;
					case"buss":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [3]);
					
						break;
					case"b2":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [4]);
			
						break;
					case"cements":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [5]);
				
						break;
					case"e46":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [6]);
				
				
						break;
					case"e61":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [7]);
		
						break;
					case"Eskavators":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [8]);
			
						break;
					case"Policija":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [9]);
				
						break;
					case"Traktors1":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [10]);
					
						break;
					case"Traktors5":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [11]);

						break;
					case"UgunsDzeseji":
						objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot[12]);
					
						break;
					

					


					}
					rezultats++;
					Debug.Log (rezultats);

				}
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.audioAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot[0]);
				switch (eventData.pointerDrag.tag) {
				case"atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrMKoord;
					break;
				case"medicina":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atraPKoord;
					break;
				case"buss":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
					break;
				case"b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;
					break;
				case"cements":
					objektuSkripts.CementaMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.CementMKoord;
					break;
				case"e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;
					break;
				case"e61":
					objektuSkripts.e61.GetComponent<RectTransform> ().localPosition = objektuSkripts.e61Koord;
					break;
				case"Eskavators":
					objektuSkripts.Eskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.EskavatorKoord;
					break;
				case"Policija":
					objektuSkripts.Policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.PolicijasKoord;
					break;
				case"Traktors1":
					objektuSkripts.Traktors1.GetComponent<RectTransform> ().localPosition = objektuSkripts.Trak1Koord;
					break;
				case"Traktors5":
					objektuSkripts.Traktors5.GetComponent<RectTransform> ().localPosition = objektuSkripts.Trak5Koord;
					break;
				case"UgunsDzeseji":
					objektuSkripts.UgunsDzeseji.GetComponent<RectTransform> ().localPosition = objektuSkripts.UgunsDKoord;
					break;
				}
			}


		}
		//if (objektuSkripts.vaiIstajaVieta = true) {
		//	rezultats=rezultats+1;
		//	Debug.Log (rezultats);
		//}
		if(rezultats==12f){
			Debug.Log ("Visas Mašīnas ieliktas vietā");
			beiguEkrans.SetActive(!beiguEkrans.activeSelf);
		}
		//if(objektuSkripts.atraPalidziba.GetComponent<CanvasGroup>().blocksRaycasts == false &&
			//objektuSkripts.atkritumuMasina.GetComponent<CanvasGroup>().blocksRaycasts == false&&
			//objektuSkripts.b2.GetComponent<CanvasGroup>().blocksRaycasts == false&&
			//objektuSkripts.CementaMasina.GetComponent<CanvasGroup>().blocksRaycasts == false&&
			//objektuSkripts.e46.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		///	objektuSkripts.e61.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		//	objektuSkripts.Eskavators.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		//	objektuSkripts.Policija.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		//	objektuSkripts.Traktors1.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		//	objektuSkripts.Traktors5.GetComponent<CanvasGroup>().blocksRaycasts == false&&
		//	objektuSkripts.UgunsDzeseji.GetComponent<CanvasGroup>().blocksRaycasts == false){
		//	Debug.Log ("Visas Mašīnas ieliktas vietā");
		//	beiguEkrans.SetActive(!beiguEkrans.activeSelf);
	//}
}
}
