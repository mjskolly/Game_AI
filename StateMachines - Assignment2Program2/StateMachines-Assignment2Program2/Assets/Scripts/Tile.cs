﻿using UnityEngine;
using System.Collections;

public class Tile {
	Vector2 gridPoint;
	Vector3 screenPoint;
	//private int gScore;
	//private int hScore;
	//public int fScore;
	//public int cost;
	//public Tile parentSquare;





	public Tile(Vector2 a, Vector3 b)
	{
		gridPoint = a;
		screenPoint = b;

		//gPoint = new GridPoint(a, b);
		//cost = c;
	}
	//public void setParentSquare(Tile ps){
	//	parentSquare = ps;
	//}
	//public void setGScore(int g){
	//	gScore = g;
	//}
	//public int getGScore(){
	//	return gScore;
	//}
	//public void setHScore(int h){
	//	hScore = h;
	//}
	//public int getHScore(){
	//	return hScore;
	//}
	//public void setFScore(){
	//	fScore = gScore+hScore;
	//}
	//public int getFScore(){
	//	return fScore;
	//}
}

//maybe remove
/*
public class GridPoint{
	public int x;
	public int y;

	public GridPoint(int a, int b){
		x = a;
		y = b;
	}	
}
public class ScreenPoint{
	public float x;
	public float y;
	
	public ScreenPoint(float a, float b){
		x = a;
		y = b;
	}	
*/
//}