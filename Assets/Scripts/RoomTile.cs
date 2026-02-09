using UnityEngine;
using System.Collections.Generic;

public class RoomTile : Tile {
  public string RoomName;
  public List<Tile> EntryPoints = new List<Tile>(); //doors
  public List<Player> OccupyingPlayers = new List<Player>(); //players in room
  public List<Weapon> WeaponsInRoom = new List<Weapon>(); //weapons in room 

  public override void Start() {
    tileType = TileType.RT;
  }

  public override bool IsWalkable(){
    return true; //mutliple players allowed in a room 
  }

  public void EnterRoom(Player player) {
    if (!OccupyingPlayer.Contains(player)) {
      OccupyingPlayers.Add(player));
      player.CurrentRoom = this; //sets player to room their currently in
    }
  }

  public void LeaveRoom(Player player) {
    if (OccupyingPlayers.Contains(player)) {
      OccupyingPlayers.Remove(player));
      player.CurrentRoom = null; //removes player from room once leaving
    }
  }

  public void AddWeapon(Weapon weapon) => WeaponsInRoom.Add(weapon);
  public void RemoveWeapon(Weapon weapon) => WeaponsInRoom.Remove(weapon);
}
