using UnityEngine;
using System.Collections;

public class MainSceneScript : MonoBehaviour {
	public GUISkin customSkin;
	private Rect startButton;
	private Rect optionButton;
	
	void Start(){
		this.startButton = InitializeButton ( 100, 45, Screen.width/2, Screen.height*2/3);	
		this.optionButton = InitializeButton ( 100, 45, Screen.width/2, (Screen.height*2/3)+65);
	}
	
	private Rect InitializeButton ( int width , int height , float centerX , float centerY ){
		Rect rect = new Rect (0,0,width,height);
		rect.center = new Vector2(centerX,centerY);
		return rect;
	}
	
	void OnGUI ( ) {
		GUI.skin = customSkin;
		if (GUI.Button( this.startButton, "Start" )) {
			Debug.Log("START");
			Application.LoadLevel("PreGameScene");
		}
		if (GUI.Button ( this.optionButton, "Options" ))
			Debug.Log("OPTIONS");
	}
}