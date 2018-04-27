using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Petunjuk : MonoBehaviour {
public Button BmulaiMain;
public Button BPetunjuk;
public Button BBack;
	// Use this for initialization
	// Update is called once per frame
	    void Start()
        {
		//		Button BBack = gameObject.GetComponent<Button>();
			//		BBack.onClick.AddListener(delegate() { StartGame("Dashboard"); });
			    
			
            
        }
       
        public void StartGame(string level)
        {
            Application.LoadLevel(level);
        }

	
	public void BackOnClick()
    {
		//		BackButton.onClick.AddListener(delegate() { StartGame("Dashboard"); });	
			
        SceneManager.LoadScene("Dashboard");
    }
}
