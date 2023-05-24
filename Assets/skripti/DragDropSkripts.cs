using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//Uzglabās norādi uz objektu skriptu
	public Objekti objektuSkripts;
	//Uzglabās norādi uz katra objekta CanvasGroup
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRecTransf;


	void Start () {

		kanvasGrupa = GetComponent<CanvasGroup> ();
		velkObjRecTransf = GetComponent<RectTransform> ();
	}

	public void OnBeginDrag(PointerEventData eventData){
	
	}
	public void OnDrag(PointerEventData eventData){

	}
	public void OnEndDrag(PointerEventData eventData){

	}
	

}
