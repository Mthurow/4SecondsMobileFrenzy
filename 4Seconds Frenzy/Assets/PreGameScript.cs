using UnityEngine;
using System.Collections;

public class PreGameScript : MonoBehaviour {
	public GUISkin customSkin;
	private Rect normalGameButton;
	private Rect hardcoreButton;
	private Rect timeAttackButton;
	
	void Start(){
		this.normalGameButton = InitializeButton ( 115, 20, 400, 200);	
		this.hardcoreButton = InitializeButton ( 75, 20, 400, 300);
		this.timeAttackButton = InitializeButton ( 95, 20, 400, 400);	
	}
	
	private Rect InitializeButton ( int width , int height , float x , float y ){
		Rect rect = new Rect (x,y,width,height);
		return rect;
	}
	
	void OnGUI ( ) {
		GUI.skin = customSkin;
		if (GUI.Button( this.normalGameButton, "Normal Game" )) {
			Application.LoadLevel("Game");
			Debug.Log("NORMAL GAME");
		}
		if (GUI.Button ( this.hardcoreButton, "Hardcore" )) {
			Application.LoadLevel("Game");
			Debug.Log("HARDCORE");
		}
		if (GUI.Button ( this.timeAttackButton, "Time Attack" )) {
			Application.LoadLevel("Game");
			Debug.Log("TIME ATTACK");
		}
	}
}