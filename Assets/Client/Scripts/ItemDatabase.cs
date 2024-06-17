// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;

public static class ItemDatabase
{
    public static Item[] Items { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]private static void Initialize() => Items = Resources.LoadAll<Item>("Items/");
}