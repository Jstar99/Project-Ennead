using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New  Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public int id;
	public int cost;
	public int power;
	public int cardHp;
	public string cardName;
	public Sprite artwork;
}
