﻿using UnityEngine;
using System.Collections;

public class Room {
	public int left;
	public int top;
	public int width;
	public int height;


	public bool isConnected=false;
	
	public int right {
		get {return left + width - 1;}
	}
	
	public int bottom {
		get { return top + height - 1; }
	}
	
	public int centerX {
		get { return left + width/2; }
	}
	
	public int centerZ {
		get { return top + height/2; }
	} 
	
	public bool CollidesWith(Room other) {
		if( left > other.right-1 )
			return false;
		if( top > other.bottom-1 )
			return false;
		if( right < other.left+1 )
			return false;
		if( bottom < other.top+1 )
			return false;
		return true;
	}

	public bool hasDoor;

	public int DoorX {
		//filler
		get{ return bottom + 1;}

	}

	public int DoorZ {
		//filer
		get{ return top - 1;}
	}




}
