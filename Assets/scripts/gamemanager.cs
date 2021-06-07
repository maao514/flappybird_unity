using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamemanager : MonoBehaviour {
	public GameObject gameovercanvas;
	public GameObject bird;
	bird Bird;
	public bool running = false;
	public bool clickButton = false;
	public CanvasGroup canvasGroup;
	public GameObject Canvas;
	// Use this for initialization
	void Start () {
		Screen.SetResolution(480, 700, false);
        //gameovercanvas.GetComponent<CanvasGroup>().alpha = 0;
        //Canvas.GetComponent<CanvasGroup>().alpha = 1;
        //Bird = bird.GetComponent<bird>();
        if (running)
        {
			Debug.Log("222");
		}
		if (!running)
        {
			Time.timeScale = 0;
			
			running = true;
			Debug.Log("333");
		}
		
		
		
	}

	void Update()
    {
        if (!running)
        {
			SceneManager.LoadScene(0);
		}
		if (clickButton)
		{
			
			clickButton = false;
			Time.timeScale = 1;
			running = true;
		}
	}
	public void StartGame()
    {
		
		clickButton = true;
		
		
	}
	// Update is called once per frame
	public void GameOver() {
        
			//Canvas.GetComponent<CanvasGroup>().alpha = 0;
			gameovercanvas.SetActive(true);
			gameovercanvas.GetComponent<CanvasGroup>().alpha = 1;
			Time.timeScale = 0;
		
		

	}
	public void replay(){
		SceneManager.LoadScene (0);
		

	}
	public void showStartUI()
    {
		canvasGroup.alpha = 1;
    }
	public void hideStartUI()
    {
		canvasGroup.alpha = 0;
    }
}
