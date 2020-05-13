package com.example.learning.basic

class Pessoa{
    lateinit var nome: String

    fun geradorDeNome(){
        nome = "asdasd"
    }
}

fun main(){
    val p = Pessoa()
    p.geradorDeNome()
}