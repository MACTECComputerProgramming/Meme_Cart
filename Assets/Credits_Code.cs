using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits_Code : MonoBehaviour {

    public void ChangeToScene (int sceneToChangeTo) { 
        //SceneManagar.LoadScene[1];
        Application.LoadLevel(sceneToChangeTo);
    }
    void Start () {
		
	}
}

