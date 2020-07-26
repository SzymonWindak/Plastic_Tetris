using UnityEngine;
using System.Collections;

public class SpawnerTetromino : MonoBehaviour {

    public GameObject[] Tetrominos;

	// Use this for initialization
	void Start () {
        NewTetromino();

    }
	
	// Update is called once per frame
	public void NewTetromino () {
        Instantiate(Tetrominos[Random.Range(0, Tetrominos.Length)], transform.position, Quaternion.identity);
	}
}
