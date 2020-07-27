using UnityEngine;
using System.Collections;

public class SpawnerTetromino : MonoBehaviour {

    public GameObject[] Tetrominos;
    public bool detector = false;
    // Use this for initialization
    void Start () {
        
            NewTetromino();
    }

    void Update()
    {
    }
	

	public void NewTetromino () {
        Instantiate(Tetrominos[Random.Range(0, Tetrominos.Length)], transform.position = new Vector3(14,10,0), Quaternion.identity);
	}

}
