// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public sealed class Tile : MonoBehaviour
{
    public int x;
    public int y;
    public Button button;
    public Image icon;

    private Item _item;

    public Item Item
    {
        get => _item;

        set
        {
            if (_item == value) return;

            _item = value;

            icon.sprite = _item.sprite;
        }
    }
    
    private void Start() => button.onClick.AddListener(() => Board.Instance.Select(this));

    public Tile Left => x > 0 ? Board.Instance.Tiles[x - 1, y] : null;
	public Tile Top => y > 0 ? Board.Instance.Tiles[x, y - 1] : null;
	public Tile Right => x < Board.Instance.Width - 1 ? Board.Instance.Tiles[x + 1, y] : null;
	public Tile Bottom => y < Board.Instance.Height - 1 ? Board.Instance.Tiles[x, y + 1] : null;

	public Tile[] Neighbours => new[]
	{
		Left,
		Top,
		Right,
		Bottom,
	};

	public List<Tile> GetConnectedTiles(HashSet<Tile> exclude = null)
	{
		exclude ??= new HashSet<Tile>();
		if (exclude.Contains(this)) return new List<Tile>();

		exclude.Add(this);
		var result = new List<Tile> { this };

		foreach (var neighbour in Neighbours)
		{
			if (neighbour != null && !exclude.Contains(neighbour) && neighbour.Item == Item)
			{
				result.AddRange(neighbour.GetConnectedTiles(exclude));
			}
		}

		return result;
	}
}