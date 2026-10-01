package com.natamora.leetcode.algorithms.problem0013_romantointeger;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class SolutionTests {

    private static Stream<Solution> solutions() {
        return Stream.of(
                new SolutionDict(),
                new SolutionWithSwitch()
        );
    }

    @ParameterizedTest
    @MethodSource("solutions")
    public void romanToIntegerTest1(Solution solution){
        var result = solution.romanToInt("III");
        assertEquals(3, result);
    }

    @ParameterizedTest
    @MethodSource("solutions")
    public void romanToIntegerTest2(Solution solution){
        var result = solution.romanToInt("LVIII");
        assertEquals(58, result);
    }

    @ParameterizedTest
    @MethodSource("solutions")
    public void romanToIntegerTest3(Solution solution){
        var result = solution.romanToInt("MCMXCIV");
        assertEquals(1994, result);
    }
}
