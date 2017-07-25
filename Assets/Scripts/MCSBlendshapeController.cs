using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MORPH3D;

public class MCSBlendshapeController : MonoBehaviour {

	private int count;
	private M3DCharacterManager m_CharacterManager;

	// Use this for initialization
	void Start () {
		count = 0;
		m_CharacterManager = GetComponent<M3DCharacterManager> ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Wall")) {
			count++;
			m_CharacterManager.SetBlendshapeValue ("FBMHeavy", count * (100.0f / 12));
	}
}

}
