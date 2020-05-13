package com.example.learning.collections

fun main(args: Array<String>){
    val l1 = listOf("Madrid", "São paulo", "Berlim")
    val l2 = mutableListOf("madrid", "são paulo", "Berlim")
    val a1 = arrayListOf("Madrid", "São Paulo", "Berlim")

    val s1 = setOf("Madrid", "São Paulo", "Berlim", "Berlim")
    val s2 = mutableSetOf("Madrid", "São Paulo", "Berlim", "Berlim")

    val h1 = hashMapOf<String, String>(Pair("Key", "Value"), Pair("França", "Paris"))
    //println(h1["França"])

    val m1 = mapOf(Pair("Key", "Value"), Pair("França", "Paris"))
    val m2 = mutableMapOf(Pair("Key", "Value"), Pair("França", "Paris"))
    //h1.entries.add()


    println(s1.size)
    l2.add("teste")
}