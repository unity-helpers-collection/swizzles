using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Swizzles
{
    public enum E4
    {
        X,
        Y,
        Z,
        W,
        Zero,
        One
    }

    public enum E3
    {
        X,
        Y,
        Z,
        Zero,
        One
    }

    public enum E2
    {
        X,
        Y,
        Zero,
        One
    }

    public static Vector2 Swiz(this Vector2 self, E2 newX, E2 newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2 Swiz(this Vector2Int self, E2 newX, E2 newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector2 self, E2 newX, E2 newY, E2 newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3 Swiz(this Vector2Int self, E2 newX, E2 newY, E2 newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector2 self, E2 newX, E2 newY, E2 newZ, E2 newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector4 Swiz(this Vector2Int self, E2 newX, E2 newY, E2 newZ, E2 newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2 Swiz(this Vector3 self, E3 newX, E3 newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2 Swiz(this Vector3Int self, E3 newX, E3 newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector3 self, E3 newX, E3 newY, E3 newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3 Swiz(this Vector3Int self, E3 newX, E3 newY, E3 newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector3 self, E3 newX, E3 newY, E3 newZ, E3 newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector4 Swiz(this Vector3Int self, E3 newX, E3 newY, E3 newZ, E3 newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2 Swiz(this Vector4 self, E4 newX, E4 newY)
    {
        return new Vector2(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector3 Swiz(this Vector4 self, E4 newX, E4 newY, E4 newZ)
    {
        return new Vector3(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector4 Swiz(this Vector4 self, E4 newX, E4 newY, E4 newZ, E4 newW)
    {
        return new Vector4(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ), self.GetElement(newW));
    }

    public static Vector2Int SwizI(this Vector2Int self, E2 newX, E2 newY)
    {
        return new Vector2Int(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2Int SwizI(this Vector2 self, E2 newX, E2 newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector2Int self, E2 newX, E2 newY, E2 newZ)
    {
        return new Vector3Int(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3Int SwizI(this Vector2 self, E2 newX, E2 newY, E2 newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }

    public static Vector2Int SwizI(this Vector3Int self, E3 newX, E3 newY)
    {
        return new Vector2Int(self.GetElement(newX), self.GetElement(newY));
    }

    public static Vector2Int SwizI(this Vector3 self, E3 newX, E3 newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector3Int self, E3 newX, E3 newY, E3 newZ)
    {
        return new Vector3Int(self.GetElement(newX), self.GetElement(newY), self.GetElement(newZ));
    }

    public static Vector3Int SwizI(this Vector3 self, E3 newX, E3 newY, E3 newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }

    public static Vector2Int SwizI(this Vector4 self, E4 newX, E4 newY)
    {
        return new Vector2Int((int) self.GetElement(newX), (int) self.GetElement(newY));
    }

    public static Vector3Int SwizI(this Vector4 self, E4 newX, E4 newY, E4 newZ)
    {
        return new Vector3Int((int) self.GetElement(newX), (int) self.GetElement(newY), (int) self.GetElement(newZ));
    }


    private static float GetElement(this Vector2 self, E2 e)
    {
        return e switch
        {
            E2.X => self.x,
            E2.Y => self.y,
            E2.Zero => 0f,
            E2.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static float GetElement(this Vector3 self, E3 e)
    {
        return e switch
        {
            E3.X => self.x,
            E3.Y => self.y,
            E3.Z => self.z,
            E3.Zero => 0f,
            E3.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static float GetElement(this Vector4 self, E4 e)
    {
        return e switch
        {
            E4.X => self.x,
            E4.Y => self.y,
            E4.Z => self.z,
            E4.W => self.w,
            E4.Zero => 0f,
            E4.One => 1f,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid element")
        };
    }

    private static int GetElement(this Vector2Int self, E2 e)
    {
        return e switch
        {
            E2.X => self.x,
            E2.Y => self.y,
            E2.Zero => 0,
            E2.One => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, null)
        };
    }

    public static int GetElement(this Vector3Int self, E3 e)
    {
        return e switch
        {
            E3.X => self.x,
            E3.Y => self.y,
            E3.Z => self.z,
            E3.Zero => 0,
            E3.One => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(e), e, null)
        };
    }
}
