using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Swizzles
{
    public enum Element
    {
        X,
        Y,
        Z,
        W,
        Zero,
        One
    }

    public static Vector2 Swiz(this Vector2 self, Element newX, Element newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2 Swiz(this Vector2Int self, Element newX, Element newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector2 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3 Swiz(this Vector2Int self, Element newX, Element newY, Element newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector2 self, Element newX, Element newY, Element newZ, Element newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector4 Swiz(this Vector2Int self, Element newX, Element newY, Element newZ, Element newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2 Swiz(this Vector3 self, Element newX, Element newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2 Swiz(this Vector3Int self, Element newX, Element newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector3 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3 Swiz(this Vector3Int self, Element newX, Element newY, Element newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector3 self, Element newX, Element newY, Element newZ, Element newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector4 Swiz(this Vector3Int self, Element newX, Element newY, Element newZ, Element newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2 Swiz(this Vector4 self, Element newX, Element newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector4 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector4 self, Element newX, Element newY, Element newZ, Element newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2Int SwizI(this Vector2Int self, Element newX, Element newY)
    {
        return new Vector2Int(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2Int SwizI(this Vector2 self, Element newX, Element newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector2Int self, Element newX, Element newY, Element newZ)
    {
        return new Vector3Int(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3Int SwizI(this Vector2 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }

    public static Vector2Int SwizI(this Vector3Int self, Element newX, Element newY)
    {
        return new Vector2Int(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2Int SwizI(this Vector3 self, Element newX, Element newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector3Int self, Element newX, Element newY, Element newZ)
    {
        return new Vector3Int(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3Int SwizI(this Vector3 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }

    public static Vector2Int SwizI(this Vector4 self, Element newX, Element newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector4 self, Element newX, Element newY, Element newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }


    private static float GetElement(this Vector2 self, Element e)
    {
        return e switch
        {
            Element.X => self.x,
            Element.Y => self.y,
            Element.Z => throw new ArgumentOutOfRangeException(nameof(e), e, "Vector2 does not have a Z element"),
            Element.W => throw new ArgumentOutOfRangeException(nameof(e), e, "Vector2 does not have a W element"),
            Element.Zero => 0f,
            Element.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static float GetElement(this Vector3 self, Element e)
    {
        return e switch
        {
            Element.X => self.x,
            Element.Y => self.y,
            Element.Z => self.z,
            Element.W => throw new ArgumentOutOfRangeException(nameof(e), e, "Vector3 does not have a W element"),
            Element.Zero => 0f,
            Element.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static float GetElement(this Vector4 self, Element e)
    {
        return e switch
        {
            Element.X => self.x,
            Element.Y => self.y,
            Element.Z => self.z,
            Element.W => self.w,
            Element.Zero => 0f,
            Element.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static int GetElement(this Vector2Int self, Element e)
    {
        return e switch
        {
            Element.X => self.x,
            Element.Y => self.y,
            Element.Z => throw new ArgumentOutOfRangeException(nameof(e), e, null),
            Element.W => throw new ArgumentOutOfRangeException(nameof(e), e, null),
            Element.Zero => 0,
            Element.One => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, null)
        };
    }

    public static int GetElement(this Vector3Int self, Element e)
    {
        return e switch
        {
            Element.X => self.x,
            Element.Y => self.y,
            Element.Z => self.z,
            Element.W => throw new ArgumentOutOfRangeException(nameof(e), e, null),
            Element.Zero => 0,
            Element.One => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, null)
        };
    }
}
