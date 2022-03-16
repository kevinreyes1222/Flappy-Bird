using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private static GameManager instance;
	
	public static GameManager Instance {get {return instance;}}
	
	
	[SerializeField] private GameObject gameOverText;
	
	public bool isGameOver;
    
	void Awake()
    {
	    if (instance == null)
	    {
	    	instance = this;
	    }else
	    {
	    	Destroy(gameObject);
	    }
    }

    
    void Update()
    {
	    if (Input.GetButtonDown("Jump") && isGameOver)
	    {
	    	RestartGame();
	    }
    }
    
	public void GameOver(){
		isGameOver = true;
		gameOverText.SetActive(true);
	}
	
	private void RestartGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
