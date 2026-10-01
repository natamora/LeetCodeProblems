package com.natamora.leetcode.algorithms.problem0013_romantointeger;

public class SolutionWithSwitch implements Solution {
    @Override
    public int romanToInt(String s) {
        int sum = 0;

        for (int i = 0; i < s.length(); i++) {
            int curr = getValue(s.charAt(i));

            if (i + 1 < s.length() && curr < getValue(s.charAt(i + 1))) {
                sum -= curr;
            } else
                sum += curr;
        }

        return sum;
    }

    private int getValue(char c) {
        return switch (c) {
            case 'I' -> 1;
            case 'V' -> 5;
            case 'X' -> 10;
            case 'L' -> 50;
            case 'C' -> 100;
            case 'D' -> 500;
            case 'M' -> 1000;
            default -> 0;
        };
    }
}
