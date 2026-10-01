package com.natamora.leetcode.algorithms.problem0013_romantointeger;

import java.util.Map;

public class SolutionDict implements Solution {

    private static final Map<Character, Integer> DICT = Map.of(
            'I', 1,
            'V', 5,
            'X', 10,
            'L', 50,
            'C', 100,
            'D', 500,
            'M', 1000
    );

    @Override
    public int romanToInt(String s) {
        int sum = 0;

        for (int i = 0; i < s.length(); i++) {
            int curr = DICT.get(s.charAt(i));
            if (i + 1 < s.length() && curr < DICT.get(s.charAt(i + 1)))
                sum -= curr;
            else
                sum += curr;
        }
        return sum;
    }
}
