using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	private void OnGUI(){
		if(GUI.Button(new Rect(100,100,100,100), "LOAD")){
			Application.LoadLevel ("Game");
		}
	}
}
