/*
Write a method that takes a field for well-known board game "Battleship" as an argument and returns true if it has a valid disposition of ships, false otherwise. Argument is guaranteed to be 10*10 two-dimension array. Elements in the array are numbers, 0 if the cell is free and 1 if occupied by ship.

Battleship (also Battleships or Sea Battle) is a guessing game for two players. Each player has a 10x10 grid containing several "ships" and objective is to destroy enemy's forces by targetting individual cells on his field. The ship occupies one or more cells in the grid. Size and number of ships may differ from version to version. In this kata we will use Soviet/Russian version of the game.

Before the game begins, players set up the board and place the ships accordingly to the following rules:
There must be single battleship (size of 4 cells), 2 cruisers (size 3), 3 destroyers (size 2) and 4 submarines (size 1). Any additional ships are not allowed, as well as missing ships.
Each ship must be a straight line, except for submarines, which are just single cell.

The ship cannot overlap or be in contact with any other ship, neither by edge nor by corner.

This is all you need to solve this kata. If you're interested in more information about the game, visit this link.
*/

namespace Solution {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  
  public class BattleshipField {
    
    public static bool ValidateBattlefield(int[,] field) {
      var hs = GetHorizontals(field);
      var vs = GetVerticals(field);
      var subs = GetSubmarines(hs, vs);
      //PrintShips(hs);
      //PrintShips(vs);
      
      if (!ValidateIfAllShips(hs, vs, subs)) return false;
      if (!ValidateIfTouching(hs, vs, subs)) return false;
      
      return true;
    }
    
    private static List<List<List<(int, int)>>> GetHorizontals(int[,] field) {
      var hs = new List<List<List<(int, int)>>>();
      
      for(var i=0; i<10; i++) {
        var hsLine = new List<List<(int, int)>>();
        var ship = new List<(int, int)>();
        for(var j=0; j<10; j++) {
          if (field[i,j] == 1) {
            if (ship.Any() && ship.LastOrDefault().Item2 + 1 == j) {              
              ship.Add((i,j));
            }
            else {
              if (ship.Any()) {
                hsLine.Add(ship);
              }
              ship = new List<(int, int)>();
              ship.Add((i,j));
            }
          }
        }
        
        if (ship.Any()) {
              hsLine.Add(ship);
            }
        
        hs.Add(hsLine);
      }
      
      return hs;
    }
    
    private static List<List<List<(int, int)>>> GetVerticals(int[,] field) {
      var vs = new List<List<List<(int, int)>>>();
      
      for(var j=0; j<10; j++) {
        var vsLine = new List<List<(int, int)>>();
        var ship = new List<(int, int)>();
        for(var i=0; i<10; i++) {
          if (field[i,j] == 1) {
            if (ship.Any() && ship.LastOrDefault().Item1 + 1 == i) {              
              ship.Add((i,j));
            }
            else {
              if (ship.Any()) {
                vsLine.Add(ship);
              }
              ship = new List<(int, int)>();
              ship.Add((i,j));
            }
          }
        }
        
        if (ship.Any()) {
          vsLine.Add(ship);
        }
        
        vs.Add(vsLine);
      }
      
      return vs;
    }
    
    private static bool ValidateIfAllShips(
      List<List<List<(int, int)>>> hs, List<List<List<(int, int)>>> vs, List<(int, int)> subs) {
      
      var hBattleships = CountShipsOfXLenght(hs, 4);
      var vBattleships = CountShipsOfXLenght(vs, 4);
      if ((hBattleships + vBattleships) != 1) return false;
      
      var hCruisers = CountShipsOfXLenght(hs, 3);
      var vCruisers = CountShipsOfXLenght(vs, 3);
      if ((hCruisers + vCruisers) != 2) return false;
      
      var hDestros = CountShipsOfXLenght(hs, 2);
      var vDestros = CountShipsOfXLenght(vs, 2);
      if ((hDestros + vDestros) != 3) return false;
      
      if (subs.Count() != 4) return false;
      
      return true;
    }
    
    private static bool ValidateIfTouching(
      List<List<List<(int, int)>>> hs, List<List<List<(int, int)>>> vs, List<(int, int)> subs) {
        
      var hPosWithoutSub = 
          from hLine in hs 
          from ship in hLine where ship.Count() > 1 
          from pos in ship
          select pos;

      var vPosWithoutSub = 
          from vLine in vs 
          from ship in vLine where ship.Count() > 1 
          from pos in ship
          select pos;
      
      foreach(var hp in hPosWithoutSub) {        
        if (vPosWithoutSub.Any(v => (
          Math.Abs(v.Item1 - hp.Item1) < 2)
          && (Math.Abs(v.Item2 - hp.Item2) < 2))) return false;
      }
      
      foreach(var vp in vPosWithoutSub) {
        if (hPosWithoutSub.Any(h => (
          Math.Abs(h.Item1 - vp.Item1) < 2)
          && (Math.Abs(h.Item2 - vp.Item2) < 2))) return false;
      }
      
      foreach(var s in subs) {
        if (vPosWithoutSub.Any(v => (
          Math.Abs(v.Item1 - s.Item1) < 2)
          && (Math.Abs(v.Item2 - s.Item2) < 2)
          && (Math.Abs(v.Item1 - s.Item1) > 0)
          && (Math.Abs(v.Item2 - s.Item2) > 0))) return false;        
        
        if (hPosWithoutSub.Any(h => (
          Math.Abs(h.Item1 - s.Item1) < 2)
          && (Math.Abs(h.Item2 - s.Item2) < 2)
          && (Math.Abs(h.Item1 - s.Item1) > 0)
          && (Math.Abs(h.Item2 - s.Item2) > 0))) return false;
      }
      
      return true;
    }
    
    
    private static void PrintShips(List<List<List<(int, int)>>> ships){
      foreach(var line in ships) {
        foreach(var ship in line) {
          foreach(var pos in ship) {
            Console.WriteLine(pos.Item1.ToString() + "-" + pos.Item2.ToString());
          }
          Console.WriteLine(",");
        }
        Console.WriteLine("----");
      }
    }
    
    private static int CountShipsOfXLenght(List<List<List<(int, int)>>> ships, int l) {
      return ships.Sum(s => s.Any(w2 => w2.Count() == l) ? 1 : 0);
    }
    
    private static List<(int, int)> GetSubmarines(List<List<List<(int, int)>>> hs, List<List<List<(int, int)>>> vs) {

      var hPos = (
          from hLine in hs 
          from ship in hLine 
          where ship.Count() == 1 
          select ship.First()).ToList();

      var vPos = (
          from vLine in vs 
          from ship in vLine 
          where ship.Count() == 1 
          select ship.First()).ToList();

      var subs =
        from h in hPos
        join v in vPos
        on new { h.Item1, h.Item2 } equals new { v.Item1, v.Item2 }
        select h;
      
      return subs.ToList();
    }
  }
}