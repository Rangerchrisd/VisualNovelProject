using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;
public class Saveload : MonoBehaviour {
	public gameManager myGamemanager;
	public void Start()
	{
		myGamemanager = GameObject.FindObjectOfType<gameManager>();
	}
	public void save(){
		StreamWriter a = new StreamWriter(Application.persistentDataPath + "/savedGames.gd");
		StringBuilder sb = new StringBuilder(20);
		//gamemanager's stuff
		sb.Append('-');
		//player's stuff
		sb.Append(myGamemanager.activePlayer);
		sb.Append('-');
		//dialogueManager's stuff
		sb.Append(myGamemanager.activeDialogueManager.saveDialogue());
		a.Write(sb.ToString());
		a.Close();
		//file.Close ();
	}
	public void Quit(){
		Application.Quit ();
	}
	public void load ()
	{
		if (File.Exists (Application.persistentDataPath + "/savedGames.gd"))
		{
			StreamReader a = new StreamReader(Application.persistentDataPath + "/savedGames.gd");
			string saveData = a.ReadToEnd();
			a.Close();
			string[] saveDataSplit = saveData.Split('-');
			//gamemanager's stuff
			//player's stuff
			loadPlayer(saveDataSplit[1]);
			//dialogueManager's stuff
			myGamemanager.activeDialogueManager.loadDialogue(saveDataSplit[2]);

		}
	}

	public string savePlayer() {
		return "";
	}
	public void loadPlayer(string playerData)
	{
		
	}
}
