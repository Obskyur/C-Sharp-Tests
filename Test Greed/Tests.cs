using System;
using NUnit.Framework;
using Test_Greed;

public static class ScoreChecker
{
    [Test]
    public static void ShouldBeWorthless()
    {
        Assert.AreEqual(0, Kata.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
    }

    [Test]
    public static void ShouldValueTriplets()
    {
        Assert.AreEqual(400, Kata.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
    }

    [Test]
    public static void ShouldValueMixedSets()
    {
        Assert.AreEqual(450, Kata.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
    }

    [Test]
    public static void Triple6()
    {
        Assert.AreEqual(600, Kata.Score(new int[] { 6, 6, 6, 2, 4 }), "Should be 600");
    }
}