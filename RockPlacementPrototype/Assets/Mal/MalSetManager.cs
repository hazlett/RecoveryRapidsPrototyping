using UnityEngine;
using System.Collections;
using OhioState.CanyonAdventure;

public class MalSetManager : MonoBehaviour {

	private MalSetSerializer serializer;
	void Start () {
		serializer = new MalSetSerializer ();
		MalSet malSet = serializer.Read ("MalQuestions.xml");
		foreach (Mal mal in malSet.malList) {
			Debug.Log(mal.id);
		}
	}


}
