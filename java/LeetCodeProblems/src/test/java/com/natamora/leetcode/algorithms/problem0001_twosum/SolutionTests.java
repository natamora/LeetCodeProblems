package com.natamora.leetcode.algorithms.problem0001_twosum;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

public class SolutionTests {
    @Test
    void twoSumTest1() {
        Solution solution = new Solution();
        int[] result = solution.twoSum(new int[] { 2, 7, 11, 15 }, 9);
        assertArrayEquals(new int[] { 0, 1 }, result);
    }

    @Test
    void twoSumTest2() {
        Solution solution = new Solution();
        int[] result = solution.twoSum(new int[] { 3, 2, 4 }, 6);
        assertArrayEquals(new int[] { 1, 2 }, result);
    }

    @Test
    void twoSumTest3() {
        Solution solution = new Solution();
        int[] result = solution.twoSum(new int[] { 3, 3 }, 6);
        assertArrayEquals(new int[] { 0, 1 }, result);
    }
}
