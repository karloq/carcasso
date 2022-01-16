using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTile
{
  public class GameTile : MonoBehaviour
  {
    private int _x;
    private int _y;

    private List<Side> _sides = new List<Side>(4);
    private int _northSide = 0;

    public GameTile(List<Side> sides, int x, int y)
    {
      _x = x;
      _y = y;
      _sides = sides;
    }

    public void RotateTile()
    {
      if (_northSide == 4)
      {
        _northSide = 0;
      }
      else
      {
        _northSide++; 
      }
    }
  
  }
} 
