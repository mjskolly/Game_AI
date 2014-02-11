﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Play : Game 
{

	private static Play instance;
	
	public static Play Instance
	{
		get { return instance ?? (instance = new GameObject("Play").AddComponent<Play>()); }
		
	}
	public static int gridLength = 16;
	public static int gridHeight = 16;

	public bool finishPressed;

	Tile[,] map = new Tile[gridLength,gridHeight];

	//spawn the number of ants entered by the player in the start menu
	//delay for 0.5 seconds between each spawn
	public void startAnts(int num){
		for(int i=0; i<num; i++){
			GameObject ant = (GameObject)Instantiate (Resources.Load ("Characters/Ant"));
			Vector3 pos = new Vector3(0,0,-5f);
			ant.transform.position = pos;
			//put delay code here
		}

	}

	public void createTerrain()
	{
		int[] startPos = startTile ();

		GameObject tile;
		Vector3 pos;
		float x = -1.75f;
		float y = -3.75f;
		for (int i=0; i<gridLength; i++) {
			for(int j=0; j<gridHeight; j++){
				if(i==startPos[0] && j==startPos[1]){
					tile = (GameObject)Instantiate (Resources.Load ("Terrain/Tile_StartPosition"));
				}
				else
				{
					tile = chooseTileType();
				}
				pos = new Vector3 (x, y, 0);
				tile.transform.position = pos;
				y+=0.5f;
			}
			x+=0.5f;
			y=-3.75f;
		}


	}

	private int[] startTile(){
		int[] pos = new int[2];
		pos[0] = Random.Range(0,16);
		pos[1] = Random.Range(0, 16);
		return pos;
	}
	private GameObject chooseTileType(){
		int random = Random.Range (0, 100);
		GameObject tile;
		if (random < 15)
			tile = (GameObject)Instantiate (Resources.Load ("Terrain/Tile_Food"));
		else if (random >= 15 && random < 30)
			tile = (GameObject)Instantiate (Resources.Load ("Terrain/Tile_Water"));
		else if (random >= 30 && random < 40)
			tile = (GameObject)Instantiate (Resources.Load ("Terrain/Tile_Poison"));
		else
			tile = (GameObject)Instantiate (Resources.Load ("Terrain/Tile_Grass"));

		return tile;
	}

	/*
	public static int gridLength = 16;
	public static int gridHeight = 16;

	public bool finishPressed = false;
	public bool playDisplayed = false;

	//public List<Tile> grid = new List<Tile> ();
	private Tile[,] grid = new Tile[gridLength,gridHeight];
	private List<GameObject> tiles = new List<GameObject>();
	public AStar astar;
	//public override void startSetup()
	//{
	//	Debug.Log("playSetup");
		//createTiles ();
		//dealTiles ();




	//}
	public int getGridLength(){
		return gridLength;
	}
	public int getGridHeight(){
		return gridHeight;
	}
	public Tile[,] getTileGrid(){
		return grid;
	}
	public void createTiles(){

		int[,] mazeData = Setup.Instance.getMazeData ();
		for(int i=0; i<gridLength; i++)
		{
			for(int j=0; j<gridHeight; j++)
			{
				Tile t = new Tile(i,j,mazeData[i,j]);
				grid[i,j] = t;
			}
		}
	}
	public void displayGrid(){

		float spacer1 = 0f;
		float spacer2 = 0f;
		for (int i=0; i<gridLength; i++) {
			for (int j=0; j<gridHeight; j++) {
				GameObject tile;
				Vector3 pos;
				switch(grid[i,j].cost){

				case 0:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/OpenSpace"));
					//pos = new Vector3 ((grid [i, j].point.x - spacer2) - 2, (grid [i, j].point.y - spacer1) - 3, 0);
					//tile.transform.position = pos;
					//tiles.Add(tile);
					grid[i,j].setGScore(0);
					break;
					case 1:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/Swamp"));
					grid[i,j].setGScore(4);
					break;
				case 2:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/Grassland"));
					grid[i,j].setGScore(3);
					break;
					case 3:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/Obstacle"));//fscore of 1000 for obstacles to make them impassable
					grid[i,j].setGScore (1000);
					break;	
				case 4:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/End"));//Lowest value for end square so its fscore will be lower
					grid[i,j].setGScore (-1);
					break;

				default:
					tile = (GameObject)Instantiate (Resources.Load ("Prefabs/Start"));//Arbitrary fscore for start because its fscore doesn't matter
					grid[i,j].setGScore(10000);
					break;
					}

				pos = new Vector3 ((grid [i, j].gPoint.x - spacer2) - 2, (grid [i, j].gPoint.y - spacer1) - 3, -5);
				tile.transform.position = pos;
				tiles.Add(tile);
								spacer1 += 0.45f;
				}
			
						spacer2 += 0.45f;
						spacer1 = 0.0f;
			}
		}
	public void startPathFinding (){
		astar = GameObject.FindObjectOfType(typeof(AStar)) as AStar;
		Debug.Log ("Start PathFinding");
		astar.aStarStart ();


		//GameObject.Destroy (astar);
	}
	private void OnGUI(){

				

		if(playDisplayed){
			if(GUI.Button(new Rect(20,40,120,20), "Finish")) {
				//Application.LoadLevel(1);

				Debug.Log("Done Pressed");
				finishPressed = true;
			}
		}
	}
	public void clearGrid(){//figure out how to destroy grid tiles
		System.Array.Clear (grid, 0, grid.Length);
		foreach (GameObject tile in tiles) {
			Destroy (tile);
		}
	}*/
}
