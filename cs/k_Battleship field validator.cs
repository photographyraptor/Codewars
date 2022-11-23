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
  
  public class BattleshipField {
    public static bool ValidateBattlefield(int[,] field) {
      var hs = GetHorizontals(field);
      var vs = GetVerticals(field);
      
      if (!ValidateIfTouching(hs, vs)) return false;
      if (!ValidateIfMissing(hs, vs)) return false;
      if (!ValidateIfMore(hs, vs)) return false;
      
      return true;
    }
    
    private static List<List<int>> GetHorizontals(int[,] field) {
      
      for(var i=0; i<10; i++) {
        for(var j=0; j<10; j++) {
          if(field[i,j] == 1) {
            
          }
        }
      }
      
      
      return new List<List<int>>();
    }
    
    
    private static List<List<int>> GetVerticals(int[,] field) {
      
      for(var j=0; j<10; j++) {
        for(var i=0; i<10; i++) {
          if(field[i,j] == 1) {
            
          }
        }
      }
      return new List<List<int>>();
    }
    
    private static bool ValidateIfTouching(List<List<int>> hs, List<List<int>> vs) {
      return false;
    }
    
    private static bool ValidateIfMissing(List<List<int>> hs, List<List<int>> vs) {
      return false;
    }
    
    private static bool ValidateIfMore(List<List<int>> hs, List<List<int>> vs) {
      return false;
    }
  }
}