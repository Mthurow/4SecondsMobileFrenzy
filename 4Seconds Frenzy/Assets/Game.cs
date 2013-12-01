using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {
	public GUISkin customSkin;
	private Rect exitGameButton;
	private Rect winGameButton;
	private Rect timeWindow;
	private List<Rect> lifeWindow;
	private double time = 4;
	private int life = 3;
	public Texture2D heartFull;
	public Texture2D heartEmpty;
	
	void Start(){
		this.lifeWindow = new List<Rect> ( );
		for ( int c = 0; c < this.life;c++) {
			this.lifeWindow.Add ( InitializeButton ( 20, 20, 850 + (c*35), 60) );
		}
		this.exitGameButton = InitializeButton ( 95, 20, 400, 400);	
		this.winGameButton = InitializeButton ( 95, 20, 600 , 200);
		this.timeWindow = InitializeButton ( 95, 20, 850, 30);
	}
	
	private Rect InitializeButton ( int width , int height , float x , float y ){
		Rect rect = new Rect (x,y,width,height);
		return rect;
	}
	
	void OnGUI ( ) {
		GUI.skin = customSkin;
		if (GUI.Button ( this.exitGameButton, "Exit" )) {
			Debug.Log("EXIT");
			Application.LoadLevel("MainScene");
		}
		if (GUI.Button ( this.winGameButton, "Win" )) {
			Debug.Log("WIN");
			time = 4;
		}
		GUI.Box ( this.timeWindow, "Time: " + (time).ToString("0.0") );
		for ( int c = 0; c < this.lifeWindow.Count;c++) {
			if ( c < life )
				GUI.Box ( this.lifeWindow[c] , heartFull );
			else
				GUI.Box ( this.lifeWindow[c] , heartEmpty );
		}
	}
	
	void Update ( ) {
		time = time - Time.deltaTime;
		if ( time <= 0 ) {
			time = 4;
			if ( life > 0 ) {
				life--;
			}
		}
	}
}
