package com.example.learning.basic

fun countVowels(phrase: String): Int {
    val VOLWES = "aeiou"
    var totalVowels = 0

    for(letter in phrase){
        if(letter.toLowerCase() in VOLWES) totalVowels++
    }
    return totalVowels
}

fun countConsonants(phrase: String): Int {
    val CONSONANTS = "bcdfghjklmnpqrstvwxyz"
    var totalConsonants = 0

    for(letter in phrase){
        if(letter.toLowerCase() in CONSONANTS) totalConsonants++
    }
    return totalConsonants
}

fun countVowelsFilter(phrase: String) = phrase.filter { it.toLowerCase() in "aeiou" }.length